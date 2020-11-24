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
    public partial class INICIO : Form
    {
        public  INICIO()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //PODER MOVER EL PANEL COMPLETO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            labelfecha.Text = DateTime.Now.ToLongDateString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PRODUCTOS>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VENTAS>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<PAGODESERVICIOS>();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN obj = new LOGIN();
            /*Aceptar obj = new Aceptar();
            obj.Show();
            */
            string usuario = Convert.ToString(Interaction.InputBox("GORDITAS MOYA","Ingrese el nombre de usuario"));
            string contraseña = Convert.ToString(Interaction.InputBox("GORDITAS MOYA","Ingrese la contraseña"));
            
            if (usuario == "RosaTorres" && contraseña == "rosa1234")
            {
                AbrirFormulario<CORTE_DE_CAJA>();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            

            
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
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

        private void panelinicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reportes>();
        }

    }
}
