using Microsoft.EntityFrameworkCore;
using proyecto4programacion.Entities;
using proyecto4programacion.Seed;

namespace proyecto4programacion.Data
{
    public class ContextoApp : DbContext
    {
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Recordatorio> recordatorios { get; set; }

        public ContextoApp(DbContextOptions<ContextoApp> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EstadoSeed());
        }

    }
}
