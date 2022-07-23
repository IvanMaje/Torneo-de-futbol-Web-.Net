using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class Fecha
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Partido> Partidos { get; set; }
        public int? TorneoId { get; set; }

    }
}
