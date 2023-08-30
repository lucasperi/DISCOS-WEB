using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Disco
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public SqlDateTime FechaLanzamiento { get; set; }

        public int CantidadCanciones { get; set; }

        public string UrlImagenTapa { get; set; }

        public Estilo Estilo { get; set; }

        public TipoEdicion TipoEdicion { get; set; }

    }
}
