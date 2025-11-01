using System.ComponentModel.DataAnnotations;

namespace proyecto4programacion.Entities
{
    public class Recordatorio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Falta agregar un Titulo")]
        [StringLength(30)]
        public string titulo { get; set; }
        [Required(ErrorMessage = "Definir dia del recordatorio")]
        [Display(Name = "Fecha del Recordatorio")]
        public DateTime? fechaRecordatorio { get; set; }
        



        
    }
}
