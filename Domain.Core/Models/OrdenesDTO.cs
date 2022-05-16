using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Models
{
    public class OrdenesDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "No Orden")]
        public string No_Orden { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Cliente")]
        public int ID_Cliente { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Precio Total")]
        public decimal Precio_Total { get; set; }
        public string Descripcion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ClientesDTO tbl_Cliente { get; set; }
        public ICollection<OrdenesDetailsDTO> Tbl_OrdenesDetail { get; set; }
    }
}
