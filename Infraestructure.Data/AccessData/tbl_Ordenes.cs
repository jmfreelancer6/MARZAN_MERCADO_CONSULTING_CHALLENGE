using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.Data.AccessData
{
    [Table("tbl_Ordenes")]
    public class Tbl_Ordenes
    {
        [Key]
        public int ID { get; set; }
        public string No_Orden { get; set; }
        public int ID_Cliente { get; set; }
        public Decimal Precio_Total { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public TimeSpan Hora_Registro { get; set; }
        [ForeignKey("ID_Cliente")]
        public virtual tbl_Clientes tbl_Clientes { get; set; }
        public ICollection<tbl_OrdenesDetails> tbl_OrdenesDetails { get; set; }
    }
}
