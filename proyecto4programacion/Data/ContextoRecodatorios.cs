using Microsoft.EntityFrameworkCore;
using proyecto4programacion.Entities;

namespace proyecto4programacion.Data
{
    public class ContextoRecodatorios : DbContext
    {
        public ContextoRecodatorios(DbContextOptions<ContextoRecodatorios> options) : base(options) { }

        public DbSet<Recordatorio> recordatorios { get; set; }
    }
}
