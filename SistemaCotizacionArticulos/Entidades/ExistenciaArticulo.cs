using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCotizacionArticulos.Entidades
{
    public class ExistenciaArticulo
    {
        [Key]
        public int ArticuloID { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
    }
}
