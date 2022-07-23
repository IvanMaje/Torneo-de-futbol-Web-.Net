using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class Torneo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadGrupos { get; set; }
        public List<Grupo> Grupos { get; set; }
        public List<Fecha> Fechas { get; set; }
        public TablaGoleadores TablaDeGoleadores { get; set; }
        public string FechaGrupo { get; set; }

    }
}
