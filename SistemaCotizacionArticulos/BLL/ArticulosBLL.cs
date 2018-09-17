using SistemaCotizacionArticulos.DAL;
using SistemaCotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCotizacionArticulos.BLL
{
    public class ArticulosBLL
    {
        
        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Articulo.Add(articulo) != null)
                {
                    //var existencia = contexto.ExistenciaArticulo.Find(articulo.ArticuloId);
                    //existencia.Existencia += 1;
                    //contexto.Entry(existencia).State = EntityState.Modified;
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;   
            Contexto contexto = new Contexto();
            try
            {
                Articulo articulo = contexto.Articulo.Find(id);
                //var existencia = contexto.ExistenciaArticulo.Find(articulo.ArticuloId);
                //existencia.Existencia -= 1;
                //contexto.Entry(existencia).State = EntityState.Modified;

                contexto.Articulo.Remove(articulo);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Articulo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulo articulo = new Articulo();
            try
            {
                articulo = contexto.Articulo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }
        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {
            List<Articulo> articulos = new List<Articulo>();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.Articulo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }
    }
}
