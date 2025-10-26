namespace proyecto4programacion.Models
{
    public class Recordatorio
    {
        public int Id { get; set; }

        public string titulo { get; set; }

        public string fechaRecordatorio { get; set; }

        public string hora { get; set; }

        public string duracion { get; set; }

        public string descripcion { get; set; }

        //Notificacion? Personas compartidas del recordatorio? importancia?
    }
}
