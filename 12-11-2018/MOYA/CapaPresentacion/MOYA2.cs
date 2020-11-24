using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace CapaPresentacion
{
    public partial class MOYA2 : Form
    {
        public MOYA2()
        {
            InitializeComponent();
        }
        LOGIN obj = new LOGIN();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            labelfecha.Text = DateTime.Now.ToLongDateString();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(String.Format("{0} 15:00:00", DateTime.Now.ToShortDateString()));

            /*if (DateTime.Now < time)
            {
                MessageBox.Show("Disponible despues de las 3 de la tarde", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/

            Aceptar obj = new Aceptar();
            DialogResult dg = new DialogResult();
            dg = obj.ShowDialog();
            
            if (dg == DialogResult.OK)
            {
                AbrirFormulario<CORTE_DE_CAJA>();
                button6.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aceptar obj = new Aceptar();
            DialogResult dg = new DialogResult();
            dg = obj.ShowDialog();

            if (dg == DialogResult.OK)
            {
                AbrirFormulario<Reportes>();
                button6.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(String.Format("{0} 15:00:00", DateTime.Now.ToShortDateString()));

            /*if (DateTime.Now > time)
            {
                MessageBox.Show("Ya se realizo el corte de caja", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
            AbrirFormulario<PAGODESERVICIOS>();
            button6.Enabled = true;
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //ventas
            DateTime time = DateTime.Parse(String.Format("{0} 15:00:00", DateTime.Now.ToShortDateString()));
            /*
            if (DateTime.Now > time)
            {
                MessageBox.Show("Ya se realizo el corte de caja", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/

            AbrirFormulario<VENTAS>();
            button6.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PRODUCTOS>();
            button6.Enabled = true;          
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //PODER MOVER EL PANEL COMPLETO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelinicio.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelinicio.Controls.Add(formulario);
                panelinicio.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void MOYA2_Load(object sender, EventArgs e)
        {
            AbrirFormulario<BIENVENIDOS>();
            button6.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BIENVENIDOS>();
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Aceptar obj = new Aceptar();
            DialogResult dg = new DialogResult();
            dg = obj.ShowDialog();

            if (dg == DialogResult.OK)
            {
                AbrirFormulario<USUARIOS>();
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Aceptar obj = new Aceptar();
            DialogResult dg = new DialogResult();
            dg = obj.ShowDialog();

            if (dg == DialogResult.OK)
            {
                AbrirFormulario<BITACORA>();
                button6.Enabled = true;
            }
        }
        

    }
}
