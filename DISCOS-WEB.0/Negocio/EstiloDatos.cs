using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EstiloDatos
    {
        public List<Estilo> estilos()
        {
            List<Estilo> estilos = new List<Estilo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.set("Select Id, Descripcion From ESTILOS");
                datos.ejecutar();
                while (datos.Lector.Read())
                {
                    Estilo aux = new Estilo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    estilos.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrar();
            }

            return estilos;
            
        }
    }
}
