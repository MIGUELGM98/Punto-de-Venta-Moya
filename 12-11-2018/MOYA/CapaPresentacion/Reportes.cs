using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;
using System.Globalization;


namespace CapaPresentacion
{
    public partial class Reportes : Form
    {
        public SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");

        public Reportes()
        {
            InitializeComponent();
            timeventas.Value = DateTime.Now;
            timeventas2.Value = DateTime.Now;
            timeventas2.Format = DateTimePickerFormat.Custom;
            timeventas2.CustomFormat = "MM";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mostrarventas(dgvventas);
            mostrarpagos(dgvpagos);
            mostrarcortecaja(dgvcortecaja);
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            mostrarventas(dgvventas);
            mostrarpagos(dgvpagos);
            mostrarcortecaja(dgvcortecaja);
        }


        public void mostrarventas(DataGridView grid)
        {
            try
            {
                Conexion.Open();
                SqlCommand cm = new SqlCommand("select * from Ventas where Fecha=" + "'" + timeventas.Value.ToShortDateString() + "'", Conexion);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            Conexion.Close();
        }

        public void mostrarpagos(DataGridView grid)
        {
            try
            {
                DateTime fecha = timeventas.Value;
                string fechaselec = (string)fecha.ToShortDateString();
                SqlCommand cm = new SqlCommand("select * from PAGOS where Fecha=" + "'" + fechaselec + "'", Conexion);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void mostrarcortecaja(DataGridView grid)
        {
            try
            {
                DateTime fecha = timeventas.Value;
                string fechaselec = (string)fecha.ToShortDateString();
                SqlCommand cm = new SqlCommand("select * from CortedeCaja where Fecha=" + "'" + fechaselec + "'", Conexion);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imprimirventas_Click(object sender, EventArgs e)
        {
            //if (dgvventas.Rows.Count < 0){            
            DGVPrinter printer = new DGVPrinter();
            String HORA, FECHA;
            HORA = DateTime.Now.ToLongTimeString();
            FECHA = DateTime.Now.ToLongDateString();
            printer.Title = "GORDITAS MOYA\n";
            printer.SubTitle = HORA + "\n " + FECHA +
               "\n\n\nINFORMACION DE LAS VENTAS";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Miguel Hidalgo #713"
                + "\nZona Centro El Mante" +
                "\nC.P. 89800" +
                "\nTel: 23-2-16-97";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvventas);
            //MessageBox.Show("Se guardo exitosamente el reporte");
            /*}
            else {
                MessageBox.Show("La tabla a imprimir esta vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void imprimirpagos_Click(object sender, EventArgs e)
        {
            //if (dgvpagos.Rows.Count < 0){            
            DGVPrinter printer = new DGVPrinter();
            String HORA, FECHA;
            HORA = DateTime.Now.ToLongTimeString();
            FECHA = DateTime.Now.ToLongDateString();
            printer.Title = "GORDITAS MOYA\n";
            printer.SubTitle = HORA + "\n" + FECHA +
               "\n\n\nINFORMACION DE LOS PAGOS REALIZADOS";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Miguel Hidalgo #713"
                + "\nZona Centro El Mante" +
                "\nC.P. 89800" +
                "\nTel: 23-2-16-97";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvpagos);
            //MessageBox.Show("Se guardo exitosamente el reporte");
            /*}
            else
            {
                MessageBox.Show("La tabla a imprimir esta vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void imprimircorte_Click(object sender, EventArgs e)
        {
            if (dgvcortecaja.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();
                String HORA, FECHA;
                HORA = DateTime.Now.ToLongTimeString();
                FECHA = DateTime.Now.ToLongDateString();
                printer.Title = "GORDITAS MOYA\n";
                printer.SubTitle = HORA + "\n" + FECHA +
                   "\n\n\nCORTE DE CAJA";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Miguel Hidalgo #713"
                    + "\nZona Centro El Mante" +
                    "\nC.P. 89800" +
                    "\nTel: 23-2-16-97";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvcortecaja);
                //MessageBox.Show("Se guardo exitosamente el reporte");
            }
            else
            {
                MessageBox.Show("La tabla a imprimir esta vacia", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarmes_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            //obtener el nombre del mes
            int numeroMes=timeventas2.Value.Month;
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            string nombreMes = formatoFecha.GetMonthName(numeroMes); 

            int sumames,sumamespago,sumamesganancia;
            int mes = timeventas2.Value.Month;            
            SqlCommand cm = new SqlCommand("select SUM(Total) from Ventas where Fecha like '%%%" + mes + "%%%%%'",Conexion);
            SqlCommand cm2 = new SqlCommand("select SUM(Cantidad) from Pagos where Fecha like '%%%" + mes + "%%%%%'", Conexion);
            SqlCommand cm3 = new SqlCommand("select SUM(Ganancia) from CortedeCaja where Fecha like '%%%" + mes + "%%%%%'", Conexion);            
            sumames = (cm.ExecuteScalar() == DBNull.Value) ? 0 : Convert.ToInt32(cm.ExecuteScalar());            
            sumamespago = (cm2.ExecuteScalar() == DBNull.Value) ? 0 : Convert.ToInt32(cm2.ExecuteScalar());
            sumamesganancia = (cm3.ExecuteScalar() == DBNull.Value) ? 0 : Convert.ToInt32(cm3.ExecuteScalar());
            MessageBox.Show("Suma de las ventas del mes de "+nombreMes+": " +sumames + "\nSuma de los pagos del mes de "+nombreMes+": "+sumamespago+"\nSuma de las ganancias del mes de "+nombreMes+": "+sumamesganancia, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Conexion.Close();
        }
    }
}
