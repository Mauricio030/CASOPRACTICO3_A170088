using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CASOPRACTICO3.model;

namespace CASOPRACTICO3
{
    /// <summary>
    /// Descripción breve de webserv
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class webserv : System.Web.Services.WebService
    {
        [WebMethod(Description = "Lista de películas")]
        public List<Caso3> Peliculas()
        {
            using (PELICULASEntities3 conexion = new PELICULASEntities3())
            {
                var consulta = (from l in conexion.Caso3 select l).ToList();
                return consulta;
            }
        }

        [WebMethod(Description = "Insertar registro de películas")]
        public bool InsertarPelicula(int id, string nombre, DateTime fecha_emision, string descripcion, string comentario, string url)
        {
            try
            {
                using (PELICULASEntities3 conexion = new PELICULASEntities3())
                {
                    Caso3 nuevaPelicula = new Caso3();
                    nuevaPelicula.id = id;
                    nuevaPelicula.nombre = nombre;
                    nuevaPelicula.fecha_emision = fecha_emision;
                    nuevaPelicula.descripcion = descripcion;
                    nuevaPelicula.comentario = comentario;
                    nuevaPelicula.url = url;
                    conexion.Caso3.Add(nuevaPelicula);
                    conexion.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod(Description = "Modificar registro de película")]
        public bool ModificarPelicula(int id, string nombre, DateTime fecha_emision, string descripcion, string comentario, string url)
        {
            try
            {
                using (PELICULASEntities3 conexion = new PELICULASEntities3())
                {
                    var consulta = (from l in conexion.Caso3 where l.id == id select l).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.nombre = nombre    ;
                        consulta.fecha_emision = fecha_emision;
                        consulta.descripcion = descripcion;
                        consulta.comentario = comentario;
                        consulta.url = url;
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod(Description = "Elminar registro")]
        public bool EliminarPelicula(int id)
        {
            try
            {
                using (PELICULASEntities3 conexion = new PELICULASEntities3())
                {
                    var consulta = (from l in conexion.Caso3 where l.id == id select l).FirstOrDefault();
                    conexion.Caso3.Remove(consulta);
                    conexion.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }

}
