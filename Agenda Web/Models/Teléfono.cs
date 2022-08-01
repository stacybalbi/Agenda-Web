using System.ComponentModel.DataAnnotations;

namespace Agenda_Web.Models
{
    public class Teléfono
    {
        [Key]
        public int Id { get; set; }
        public string telefono{ get; set; }
        public string  id_usuario { get; set; }
    }
}
