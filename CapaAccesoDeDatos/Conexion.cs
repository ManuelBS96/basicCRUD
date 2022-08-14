using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDeDatos
{
    
    public class Conexion
    {

        private SqlConnection Conn = new SqlConnection("Server= localhost;DataBase = CRUDbasico; Integrated Security = true");
        public SqlConnection AbrirConexion()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            return Conn;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            return Conn;
        }
    }
}
