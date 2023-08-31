using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DiscoDatos
    {
        public List<Disco> discos()
        {
            List<Disco> discos = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.set("Select D.Id as Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, E.Descripcion as Estilo, IdTipoEdicion, T.Descripcion as Edicion from DISCOS D, ESTILOS E, TIPOSEDICION T where IdEstilo = E.Id and IdTipoEdicion = T.Id");
                datos.ejecutar();
                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (SqlDateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["Edicion"];

                    discos.Add(aux);
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

            return discos;
        }
    }
}
