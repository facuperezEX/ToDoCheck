using Microsoft.EntityFrameworkCore;

namespace proyecto4programacion.Data
{
    public class PrometeoContext : DbContext
    {
        public PrometeoContext(DbContextOptions<PrometeoContext> options) : base(options) { }
    }
}
