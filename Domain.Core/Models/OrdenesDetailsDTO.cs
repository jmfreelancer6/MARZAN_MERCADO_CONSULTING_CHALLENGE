using System;

namespace Domain.Core.Models
{
    public class OrdenesDetailsDTO
    {
        public int id { get; set; }
        public int ID_Ordenes { get; set; }
        public int ID_Productos { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public TimeSpan Hora_Registro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual OrdenesDTO tbl_Ordenes { get; set; }
        public ProductosDTO tbl_Productos { get; set; }
    }
}
