using PrimerProyecto.DAL;
using PrimerProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos producto)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Productos.Add(producto) != null)
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


        public static bool Modificar(Productos producto)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(producto).State = EntityState.Modified;
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
                Productos producto = contexto.Productos.Find(id);

                contexto.Productos.Remove(producto);

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


        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos producto = new Productos();
            try
            {
                producto = contexto.Productos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }


        public static List<Productos> GetList(Expression<Func<Productos, bool>> expression)
        {
            List<Productos> productos = new List<Productos>();
            Contexto contexto = new Contexto();

            try
            {
                productos = contexto.Productos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return productos;
        }

    }
}
