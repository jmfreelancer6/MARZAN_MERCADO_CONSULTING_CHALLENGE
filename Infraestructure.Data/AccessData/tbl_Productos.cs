using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.Data.AccessData
{
    [Table("tbl_Productos")]
    public class tbl_Productos
    {
        [Key]
        public int ID { get; set; }
        public string No_Producto { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public string Codigo_Barras { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public TimeSpan Hora_Registro { get; set; }
        public ICollection<tbl_OrdenesDetails> Tbl_OrdenesDetail { get; set; }
    }
}
