using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class Equipo: IComparable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadJugadores { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public int Puntos { get; set; }
        public int Ganados { get; set; }
        public int Perdidos { get; set; }
        public int Empatados { get; set; }
        public int GolesAFavor { get; set; }
        public int GolesEnContra { get; set; }
        public int GrupoId { get; set; }
        public int? CopaOroId { get; set; }
        public int? CopaPlataId { get; set; }

        public int CompareTo(object obj)
        {
            Equipo equipo2 = (Equipo)obj;

            int aux = this.Puntos.CompareTo(equipo2.Puntos);

            if(aux == 0)
            {
               aux= (this.GolesAFavor - this.GolesEnContra).CompareTo(equipo2.GolesAFavor - equipo2.GolesEnContra);
            }

            return -aux;
        }
    }
}
