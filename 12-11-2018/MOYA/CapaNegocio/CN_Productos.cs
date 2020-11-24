using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd(){
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProduc(String Codigo,String Nombre, String Precio){
            objetoCD.Insertar(Convert.ToInt32(Codigo),Nombre,Convert.ToInt32(Precio));
          }
        public void EditarProduc(String Codigo, String Nombre, String Precio,String ID){
            objetoCD.Editar(Convert.ToInt32(Codigo), Nombre, Convert.ToInt32(Precio),Convert.ToInt32(ID));
        }
        public void EliminarProducto(string ID){
           objetoCD.eliminar(Convert.ToInt32(ID));
        }
    }
}
