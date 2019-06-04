using PrimerProyecto.DAL;
using PrimerProyecto.Entidades;
using PrimerProyecto.UI.Registros;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto.BLL
{
   public  class UbicacionesBLL
    {
        public static bool Guardar(Ubicaciones ubicacion)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Ubicacion.Add(ubicacion) != null)
                {
                    contexto.SaveChanges();
                    estado = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return estado;
        }

        public static bool Modificar(Ubicaciones ubicaciones)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(ubicaciones).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    estado = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return estado;
        }


        public static bool Eliminar(int id)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                Ubicaciones ubicacion = contexto.Ubicacion.Find(id);

                contexto.Ubicacion.Remove(ubicacion);

                if (contexto.SaveChanges() > 0)
                {
                    estado = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return estado;
        }

        public static Ubicaciones Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ubicaciones ubicacion = new Ubicaciones();
            try
            {
                ubicacion = contexto.Ubicacion.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return ubicacion;


        }
        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> expression)
        {
            List<Ubicaciones> ubicacion = new List<Ubicaciones>();
            Contexto contexto = new Contexto();

            try
            {
                ubicacion = contexto.Ubicacion.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return ubicacion;
        }
    }
}
