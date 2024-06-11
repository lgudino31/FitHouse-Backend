using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS.ENTIDADES
{
    public class Productos
    {
        [Key]
        //[NotMapped]
        public int Id_Producto { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Nombre_Producto { get; set; }
        public string Dificultad { get; set; }
        public int Cant_Clases { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
    }
}
