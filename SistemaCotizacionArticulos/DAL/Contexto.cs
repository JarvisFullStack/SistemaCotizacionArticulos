using SistemaCotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCotizacionArticulos.DAL
{
    class Contexto : DbContext
    {
        
        public DbSet<Articulo> Articulo { get; set; }

        public Contexto() : base("ConStr")
        { }
        
    }
}
