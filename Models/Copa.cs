using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class Copa
    {
        public int Id { get; set; }
        public List<Equipo> equipos { get; set; }
        public int TorneoId { get; set; }

    }
}
