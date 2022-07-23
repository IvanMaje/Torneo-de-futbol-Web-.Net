using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class TablaGoleadores
    {
        public int Id { get; set; }
        public List<Jugador> jugadores { get; set; }
        public int TorneoId { get; set; }
    }
}
