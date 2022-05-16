using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.Data.AccessData
{
    [Table("tbl_Ordenes_Details")]
    public class tbl_OrdenesDetails
    {
        [Key]
        public int id { get; set; }
        public int ID_Ordenes { get; set; }
        public int ID_Productos { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        [ForeignKey("ID_Ordenes")]
        public Tbl_Ordenes tbl_Ordenes { get; set; }
        [ForeignKey("ID_Productos")]
        public tbl_Productos tbl_Productos { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public TimeSpan Hora_Registro { get; set; }
    }
}
