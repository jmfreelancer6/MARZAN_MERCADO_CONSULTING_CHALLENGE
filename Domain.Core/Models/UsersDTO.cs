using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Models
{
    public class UsersDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string usuario { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        public string Contrasena { get; set; }
    }
}
