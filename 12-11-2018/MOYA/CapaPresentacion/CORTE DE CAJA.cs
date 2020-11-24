using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class CORTE_DE_CAJA : Form
    {

        public SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");

        public CORTE_DE_CAJA()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int contarNumVentas, sumarventas=0, contarNumPagos, sumarpagos=0, ganacias;
        private void CORTE_DE_CAJA_Load(object sender, EventArgs e)
        {
            cargardatos(); 
        }
        public void limpiarlabel()
        {
            numventas.Text = "";
            numegresos.Text = "";
            totalventas.Text = "";
            totalpagos.Text = "";
            dinerototal.Text = "";
        }
        private void cargardatos() {
                Conexion.Open();
                string fecha = DateTime.Now.ToShortDateString();
                SqlCommand command = new SqlCommand("SELECT COUNT(*)FROM Ventas where Fecha=CONVERT(VARCHAR(10), GETDATE(),103)", Conexion);
                SqlCommand command2 = new SqlCommand("SELECT SUM(Total)FROM Ventas where Fecha=CONVERT(VARCHAR(10), GETDATE(),103)", Conexion);
                SqlCommand command3 = new SqlCommand("SELECT COUNT(*)FROM PAGOS where Fecha=CONVERT(VARCHAR(10), GETDATE(),103)", Conexion);
                SqlCommand command4 = new SqlCommand("SELECT SUM(Cantidad)FROM PAGOS where Fecha=CONVERT(VARCHAR(10), GETDATE(),103)", Conexion);

                
                contarNumVentas = (int)command.ExecuteScalar();
                numventas.Text = contarNumVentas.ToString();
                
                sumarventas = (command2.ExecuteScalar()==DBNull.Value)? 0: Convert.ToInt32(command2.ExecuteScalar());
                totalventas.Text = sumarventas.ToString();

                contarNumPagos = (int)command3.ExecuteScalar();
                numegresos.Text = contarNumPagos.ToString();

                sumarpagos = (command4.ExecuteScalar() == DBNull.Value) ? 0 : Convert.ToInt32(command4.ExecuteScalar());
                totalpagos.Text = sumarpagos.ToString();
                
                ganacias = sumarventas - sumarpagos;
                dinerototal.Text = ganacias.ToString();
                Conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dinerototal.Text == "0")
            {
                MessageBox.Show("No se ah realizado niguna venta el dia de hoy", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea realizar el corte de caja?", "Corte de Caja", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conexion.Open();
                    try
                    {
                        SqlCommand agregar = new SqlCommand("Corte", Conexion);
                        agregar.CommandType = CommandType.StoredProcedure;
                        agregar.Parameters.AddWithValue("@Fecha", DateTime.Now.ToShortDateString());
                        agregar.Parameters.AddWithValue("@NumVentas", contarNumVentas);
                        agregar.Parameters.AddWithValue("@TotalVentas", sumarventas);
                        agregar.Parameters.AddWithValue("@NumEgresos", contarNumPagos);
                        agregar.Parameters.AddWithValue("@TotalEgresos", sumarpagos);
                        agregar.Parameters.AddWithValue("@Ganancia", ganacias);
                        agregar.ExecuteNonQuery();
                        agregar.Parameters.Clear();
                        MessageBox.Show("Corte de caja realizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ya se realizo el corte de caja de la fecha: " + DateTime.Now.ToLongDateString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Conexion.Close();
                }
                else
                {
                    MessageBox.Show("Corte de caja cancelado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void imprimir_Click(object sender, EventArgs e)
        {
        }
    }
}
