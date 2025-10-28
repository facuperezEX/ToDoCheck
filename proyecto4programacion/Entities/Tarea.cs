
using System.ComponentModel.DataAnnotations;

namespace proyecto4programacion.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titulo requerido")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Minimo 3 caracteres")]
        [Display(Name = "Tarea")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Descripcion de tarea requerida")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Minimo 8 caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime? FechaCreacion { get; set; }
        [Display(Name = "Fecha de realización")]
        public DateTime? FechaCompletado { get; set; }
        public Estado? Estado { get; set; }

        public Tarea() { }
    }
}
