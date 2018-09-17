using SistemaCotizacionArticulos.DAL;
using SistemaCotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCotizacionArticulos.BLL
{
    public class ExistenciaArticuloBLL
    {
        /*
        public static bool Guardar(ExistenciaArticulo existencia)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.ExistenciaArticulo.Add(existencia) != null)
                {
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

        public static bool Modificar(ExistenciaArticulo existencia)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(existencia).State = System.Data.Entity.EntityState.Modified;
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
                ExistenciaArticulo existencia = contexto.ExistenciaArticulo.Find(id);
                contexto.ExistenciaArticulo.Remove(existencia);
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

        public static ExistenciaArticulo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            ExistenciaArticulo existencia = new ExistenciaArticulo();
            try
            {
                existencia = contexto.ExistenciaArticulo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return existencia;
        }
        public static List<ExistenciaArticulo> GetList(Expression<Func<ExistenciaArticulo, bool>> expression)
        {
            List<ExistenciaArticulo> existencias = new List<ExistenciaArticulo>();
            Contexto contexto = new Contexto();
            try
            {
                existencias = contexto.ExistenciaArticulo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return existencias;
        }*/
    }
}

