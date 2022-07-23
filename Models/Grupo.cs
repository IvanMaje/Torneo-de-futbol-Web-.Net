using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public int Nombre { get; set; }
        public List<Equipo> Equipos { get; set; }
        public int TorneoId { get; set; }
    }
}
