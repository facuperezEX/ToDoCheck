using Microsoft.EntityFrameworkCore;
using proyecto4programacion.Entities;

namespace proyecto4programacion.Data
{
    public class PrometeoContext : DbContext
    {
        public DbSet<Tarea> Tarea { get; set; }

        public PrometeoContext(DbContextOptions<PrometeoContext> options) : base(options) { }

    }
}
