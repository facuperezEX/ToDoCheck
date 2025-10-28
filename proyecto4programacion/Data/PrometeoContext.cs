using Microsoft.EntityFrameworkCore;
using proyecto4programacion.Entities;
using proyecto4programacion.Seed;

namespace proyecto4programacion.Data
{
    public class PrometeoContext : DbContext
    {
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Estado> Estados { get; set; }

        public PrometeoContext(DbContextOptions<PrometeoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EstadoSeed());
        }

    }
}
