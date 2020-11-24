using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Pagos
    {
        private ConexionSql conexion = new ConexionSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPagos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public void Insertar(string Descripcion, int Cantidad,string Fecha)
        {
            //PROCEDIMNIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Nuevopago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Fecha",DateTime.Now.ToShortDateString());
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Editar(string Descripcion, int Cantidad, int ID, string Fecha)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Fecha", DateTime.Now.ToShortDateString());
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Eliminar(int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }














    }

     
}
