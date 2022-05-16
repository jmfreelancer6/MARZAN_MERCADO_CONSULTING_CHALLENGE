using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Models
{
    public class ProductosDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "No Producto")]
        public string No_Producto { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        [Display(Name = "Codigo de Barras")]
        public string Codigo_Barras { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public ICollection<OrdenesDetailsDTO> Tbl_Ordenes { get; set; }
    }
}
