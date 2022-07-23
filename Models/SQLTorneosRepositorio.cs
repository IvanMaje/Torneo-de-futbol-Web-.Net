using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class SQLTorneosRepositorio: ITorneoAlmacen
    {
        private readonly AppDbContext contexto;
        
        public SQLTorneosRepositorio(AppDbContext contexto)
        {
            this.contexto = contexto;
        }
        
        public List<Grupo> DameGruposConEquipos(int torneoId)
        {
            List<Grupo> grupos = contexto.Grupos.Where(x => x.TorneoId == torneoId).Include(x => x.Equipos).ToList();
            return grupos;
        }

        public List<Fecha> DameFechas(int torneoId)
        {
            List<Fecha> fecha = contexto.Fechas.Where(x => x.TorneoId == torneoId).ToList();
            return fecha;
        }

        public Fecha DameFecha(int torneoId, String fechaNombre)
        {
            List<Fecha> fecha = contexto.Fechas.Where(x => x.TorneoId == torneoId && x.Nombre == fechaNombre).Include(x => x.Partidos).ToList();
            foreach (Partido partido in fecha[0].Partidos)
            {
                partido.Equipo1 = contexto.Equipos.Find(partido.Equipo1Id);
                partido.Equipo2 = contexto.Equipos.Find(partido.Equipo2Id);
            }
            return fecha[0];
        }

        public Equipo DameEquipo(int equipoId)
        {
            Equipo equipo = contexto.Equipos.Find(equipoId);
            return equipo;
        }

        public Equipo DameEquipoConJugadores(int equipoId)
        {
            Equipo equipo = contexto.Equipos.Find(equipoId);
            equipo.Jugadores = DameJugadores(equipo.Id);
            return equipo;
        }

        public List<Jugador> DameJugadores(int equipoId)
        {
            List<Jugador> jugadores = contexto.Jugadores.Where(x => x.EquipoId == equipoId).ToList();
            return jugadores;
        }

        public List<Jugador> DameJugadoresDeTablaGoleadores(int tablaGoleadoresId)
        {
            List<Jugador> jugadores = contexto.Jugadores.Where(x => x.TablaGoleadoresId == tablaGoleadoresId).ToList();
            List<Jugador> jugadoresOrdenados = jugadores.OrderByDescending(x => x.cantidadGoles).ToList();
            return jugadoresOrdenados;
        }

    }
}
