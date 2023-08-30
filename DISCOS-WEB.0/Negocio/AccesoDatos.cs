using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    internal class AccesoDatos
    {
        public SqlConnection connection;

        public SqlCommand command;

        public SqlDataReader reader;

        public SqlDataReader Reader
        { get { return reader; } }

        public AccesoDatos()
        {
            connection = new SqlConnection();
        }

    }
}
