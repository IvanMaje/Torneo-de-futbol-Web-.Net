using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Torneo.Models
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Torneo> Torneos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Fecha> Fechas { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<CopaOro> CopasDeOro { get; set; }
        public DbSet<CopaPlata> CopasDePLata { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<TablaGoleadores> TablaGoleadores { get; set; }


    }
}
