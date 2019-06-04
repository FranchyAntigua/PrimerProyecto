using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.Entidades
{
   public  class Ubicaciones
    {
        [Key]
        public int UbicacionId { get; set; }
        public string Descripcion { get; set; }

        public Ubicaciones()
        {
            this.UbicacionId = 0;
            this.Descripcion = string.Empty;
        }
    }
}

