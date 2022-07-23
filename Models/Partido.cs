using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class Partido
    {
        public int Id { get; set; }
        public Equipo Equipo1 { get; set; }
        public Equipo Equipo2 { get; set; }
        public int GolesEquipo1 { get; set; }
        public int GolesEquipo2 { get; set; }
        public string JudadorDelPartido { get; set; }
        public bool SeJugo { get; set; }  // Indica si el partido se jugo (true) o no se jugo (false)
        public int FechaId { get; set; }
        public int Equipo1Id { get; set; }
        public int Equipo2Id { get; set; }
    }
}
