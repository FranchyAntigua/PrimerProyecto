﻿using PrimerProyecto.DAL;
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
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Productos.Add(producto) != null)
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


        public static bool Modificar(Productos producto)
        {
            bool estado = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(producto).State = EntityState.Modified;
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
                Productos producto = contexto.Productos.Find(id);

                contexto.Productos.Remove(producto);

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

        public static int CalcularVI(int existencia, int costo)
        {
            int resultado = 0;
            resultado = existencia * costo;

            return resultado;
        }

    }
}
