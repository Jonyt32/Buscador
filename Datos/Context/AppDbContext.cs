using Datos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Disponibilidad> Disponibilidades { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
        public DbSet<Sedes> Sedes { get; set; }
        public DbSet<TipoAlojamiento> TipoHabitaciones { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
