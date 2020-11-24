using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_INICIARSESION
    {
        private ConexionSql conexion = new ConexionSql();
        private SqlDataReader leer;

        public SqlDataReader IniciarSesion(string user,string pass)
        {
            SqlCommand comando = new SqlCommand("IniciarSesion", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", user);
            comando.Parameters.AddWithValue("@Password", pass);
            leer=comando.ExecuteReader();
            return leer;


            /*string sql = "select * from Usuarios where Dni='" + user + "' and Contraseña='" + pass + "';";
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
            */
        }
    }
}
