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
using DGVPrinterHelper;
namespace CapaPresentacion
{

    public partial class BITACORA : Form
    {
        public BITACORA()
        {
            InitializeComponent();
            
        }
        public SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void mostrarbitacora(DataGridView grid)
        {
            try
            {
                Conexion.Open();
                SqlCommand cm = new SqlCommand("select * from BITACORA order by  Fecha_Hora asc", Conexion);
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

        private void BITACORA_Load(object sender, EventArgs e)
        {
            mostrarbitacora(dgvbitacora);
        }

        private void dgvbitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void imprimirpagos_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            String HORA, FECHA;
            HORA = DateTime.Now.ToLongTimeString();
            FECHA = DateTime.Now.ToLongDateString();
            printer.Title = "GORDITAS MOYA\n";
            printer.SubTitle = HORA + "\n " + FECHA +
               "\n\n\nHISTORIAL DE BITACORA";
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
            printer.PrintDataGridView(dgvbitacora);
            
        }

    }


}
