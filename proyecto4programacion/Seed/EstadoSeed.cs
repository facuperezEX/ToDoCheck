using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyecto4programacion.Entities;

namespace proyecto4programacion.Seed
{
    public class EstadoSeed : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasData(
                new Estado() { Id = 1, Descripcion = "Pendiente" },
                new Estado() { Id = 2, Descripcion = "Completada" }
            );
        }
    }
}
