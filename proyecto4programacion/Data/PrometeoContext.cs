using Microsoft.EntityFrameworkCore;
using proyecto4programacion.Entities;

namespace proyecto4programacion.Data
{
    public class PrometeoContext : DbContext
    {
        public PrometeoContext(DbContextOptions<PrometeoContext> options) : base(options) { }

        public DbSet<Recordatorio> recordatorios { get; set; }
    }
}
