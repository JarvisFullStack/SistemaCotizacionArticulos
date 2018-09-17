using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaCotizacionArticulos.BLL;
using SistemaCotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCotizacionArticulos.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulo articulo = new Articulo()
            {
            //ArticuloId = 0;
            FechaVencimiento = DateTime.Now,
            Descripcion = "Articulo5",
            Precio = 3000,
            Existencia = 2,
            CantidadCotizada = 1
        };
            
            bool paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Articulo articulo = new Articulo()
            {
                ArticuloId = 1,
                FechaVencimiento = DateTime.Now,
                Descripcion = "ArticuloModificado",
                Precio = 3000,
                Existencia = 2,
                CantidadCotizada = 1
            };
            bool paso = ArticulosBLL.Modificar(articulo);
            Assert.AreEqual(paso, true);
            
        }

        [TestMethod()]
        public void EliminarTest()
        {
            
            bool paso = ArticulosBLL.Eliminar(1);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Articulo articulo = ArticulosBLL.Buscar(1);
            Assert.AreEqual(articulo, null);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            paso = ArticulosBLL.GetList(x => true).Count() > 0;
            Assert.AreEqual(paso, true);
     
        }
    }
}