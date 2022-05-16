using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraestructure.Data.AccessData
{
    [Table("tbl_Clientes")]
    public class tbl_Clientes
    {

        [Key]
        public int ID { get; set; }
        public string No_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public TimeSpan Hora_Registro { get; set; }
        public ICollection<Tbl_Ordenes> Tbl_Ordenes { get; set; }
    }
}
