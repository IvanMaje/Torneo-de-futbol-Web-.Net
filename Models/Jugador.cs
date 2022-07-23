using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int cantidadGoles { get; set; }
        public int EquipoId { get; set; }
        public int? TablaGoleadoresId { get; set; }
    }
}
