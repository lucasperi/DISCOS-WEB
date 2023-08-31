using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EdicionDatos
    {

        public List<TipoEdicion> ediciones()
        {
            List<TipoEdicion> ediciones = new List<TipoEdicion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.set("Select Id, Descripcion From TIPOSEDICION");
                datos.ejecutar
                while (datos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    ediciones.Add(aux);
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

            return ediciones;
        }
    }
}
