using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public int Costo { get; set; }
        public int ValorInventario { get; set; }

        public Productos()
        {
            this.ProductoId = 0;
            this.Descripcion = string.Empty;
            this.Existencia = 0;
            this.Costo = 0;
            this.ValorInventario = 0;
        }
    }
}
