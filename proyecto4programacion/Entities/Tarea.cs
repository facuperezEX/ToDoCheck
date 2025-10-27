
namespace proyecto4programacion.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaCompletado { get; set; }
        public string? Estado { get; set; }

        public Tarea() { }
    }
}
