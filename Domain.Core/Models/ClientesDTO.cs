using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core.Models
{
    public class ClientesDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "No Cliente")]
        public string No_Cliente { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Apellido { get; set; }
        [StringLength(50)]
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        [Display(Name = "Fecha")]
        public DateTime Fecha_Registro { get; set; }
        [Display(Name = "Hora")]
        public TimeSpan Hora_Registro { get; set; }
        public ICollection<OrdenesDTO> Tbl_Ordenes { get; set; }
    }
}
