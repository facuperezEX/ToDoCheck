using Microsoft.EntityFrameworkCore;
using proyecto4programacion.Entities;
using proyecto4programacion.Seed;

namespace proyecto4programacion.Data
{
    public class ContextoTareas : DbContext
    {
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Estado> Estados { get; set; }

        public ContextoTareas(DbContextOptions<ContextoTareas> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EstadoSeed());
        }

    }
}
