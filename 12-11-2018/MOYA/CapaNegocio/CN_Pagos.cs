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
    public class CN_Pagos
    {
        private CD_Pagos objetoCD = new CD_Pagos();

        public DataTable MostrarPagos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void Nuevopago(String Descripcion, String Cantidad,String Fecha)
        {
            objetoCD.Insertar(Descripcion, Convert.ToInt32(Cantidad),Fecha);
        }
        public void EditarPago(String Descripcion, String Cantidad, String ID,String Fecha)
        {
            objetoCD.Editar(Descripcion, Convert.ToInt32(Cantidad), Convert.ToInt32(ID),Fecha);
        }
        public void EliminarPago(string ID)
        {
            objetoCD.Eliminar(Convert.ToInt32(ID));
        }
    }
}
