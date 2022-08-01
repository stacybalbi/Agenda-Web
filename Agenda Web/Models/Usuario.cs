using System.ComponentModel.DataAnnotations;

namespace Agenda_Web.Models
{
    public class Usuario
    {
        [Key] //Atributo Key para incrementar el Id
        public int Id { get; set; }

        public Boolean visible { get; set; } = true;
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Apellido { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        [Required(ErrorMessage = "El Número de teléfono es obligatorio")]
        public string email { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string direccion { get; set; }

        

    }
}
