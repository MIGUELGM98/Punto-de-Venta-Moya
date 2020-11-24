using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class ConexionSql
    {
       private SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");
       public SqlConnection AbrirConexion()
       {
           if (Conexion.State == ConnectionState.Closed)
               Conexion.Open();
           return Conexion;
       }

       public SqlConnection CerrarConexion()
       {
           if (Conexion.State == ConnectionState.Open)
               Conexion.Close();
           return Conexion;
       }
    }
}
