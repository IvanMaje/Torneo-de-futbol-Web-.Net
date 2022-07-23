using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public interface ITorneoAlmacen
    {
        public List<Grupo> DameGruposConEquipos(int torneoId);
        public List<Fecha> DameFechas(int torneoId);
        public Fecha DameFecha(int torneoId, String fechaNombre);
        public Equipo DameEquipo(int equipoId);
        public Equipo DameEquipoConJugadores(int equipoId);
        public List<Jugador> DameJugadoresDeTablaGoleadores(int tablaGoleadoresId);
    }
}
