using Web_Torneo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Controllers
{
    public class HomeController: Controller
    {
        private ITorneoAlmacen TorneosAlmacen;

        public HomeController(ITorneoAlmacen TorneosAlmacen)
        {
            this.TorneosAlmacen = TorneosAlmacen;
        }

        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [Route("Home/Tabla_Posiciones")]
        public ViewResult Tabla_Posiciones()
        {
            List<Grupo> grupos = TorneosAlmacen.DameGruposConEquipos(1);
            foreach (Grupo grupo in grupos)
            {
                grupo.Equipos.Sort();
            }

            return View(grupos);
        }

        [Route("Home/Fixture/{fechaNombre}")]

        public ViewResult Fixture(String fechaNombre)
        {
            List<Fecha> fechas = TorneosAlmacen.DameFechas(1);
            ViewBag.fecha = TorneosAlmacen.DameFecha(1, fechaNombre);

            return View(fechas);
        }

        [Route("Home/Tabla_Goleadores/{tablaGoleadoresId}")]

        public ViewResult Tabla_Goleadores(int tablaGoleadoresId)
        {
            List<Jugador> jugadores = TorneosAlmacen.DameJugadoresDeTablaGoleadores(tablaGoleadoresId);

            List<String> nombreEquipos = new List<string>();
            int i = 0;

            foreach (Jugador jugador in jugadores)
            {
                i++;
                nombreEquipos.Add(TorneosAlmacen.DameEquipo(jugador.EquipoId).Nombre);

                if (i > 10)
                {
                    break;
                }

                ViewBag.NombreEquipos = nombreEquipos;

            }

            return View(jugadores);
        }

        [Route("Home/Equipo_Detalles/{equipoId}")]

        public ViewResult Equipo_Detalles(int equipoId)
        {
            Equipo equipo = TorneosAlmacen.DameEquipoConJugadores(equipoId);
            return View(equipo);
        }

    }
}
