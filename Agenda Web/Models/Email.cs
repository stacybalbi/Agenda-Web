using System.ComponentModel.DataAnnotations;

namespace Agenda_Web.Models
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        public string email { get; set; }
        public string id_usuario { get; set; }
    }
}
