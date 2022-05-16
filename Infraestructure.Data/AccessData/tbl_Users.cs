using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.Data.AccessData
{
    [Table("tbl_Users")]
    public class tbl_Users
    {
        [Key]
        public int ID { get; set; }
        public string usuario { get; set; }
        public string Contrasena { get; set; }
    }
}
