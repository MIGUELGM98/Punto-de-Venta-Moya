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
using System.Data.SqlClient;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        public SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            labelfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void textusuario_Leave(object sender, EventArgs e)
        {
            if (textusuario.Text == "")
            {
                textusuario.Text = "Usuario";
                textusuario.ForeColor = Color.White;
            }
        }

        private void textusuario_Enter(object sender, EventArgs e)
        {
            if (textusuario.Text == "Usuario")
            {
                textusuario.Text = "";
                textusuario.ForeColor = Color.White;
            }
        }

        private void textcontraseña_Leave(object sender, EventArgs e)
        {
            if (textcontraseña.Text == "")
            {
                textcontraseña.Text = "Contraseña";
                textcontraseña.ForeColor = Color.White;
                textcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void textcontraseña_Enter(object sender, EventArgs e)
        {
            if (textcontraseña.Text == "Contraseña")
            {
                textcontraseña.Text = "";
                textcontraseña.ForeColor = Color.White;
                textcontraseña.UseSystemPasswordChar = true;
            }
        }



        SqlDataReader leer,leer2;


        private void button1_Click(object sender, EventArgs e){
            string user, pass;
            user = textusuario.Text;
            pass = textcontraseña.Text;
            
            Conexion.Open();
            SqlCommand comando = new SqlCommand("IniciarSesionLogin", Conexion);            
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", user);
            comando.Parameters.AddWithValue("@Password", pass);
            leer=comando.ExecuteReader();
            if (leer.Read() == true)
            {
            Conexion.Close();
            Conexion.Open();                       
                this.Hide();
                MOYA2 obj = new MOYA2();
                obj.Show();
                SqlCommand comando2 = new SqlCommand("inicio", Conexion);
                comando2.CommandType = CommandType.StoredProcedure;
                comando2.Parameters.AddWithValue("@Usuario", user);
                comando2.Parameters.AddWithValue("@Contraseña", pass);
                leer2 = comando2.ExecuteReader();
            }
            else {
                lblErrorLogin.Text = "Usuario o contraseña incorrectos";
                textusuario.Text = "";
                textcontraseña.Text = "";
                textusuario.Focus();
            }
            Conexion.Close();

            
        }


        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            //PODER MOVER EL PANEL COMPLETO
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void textcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
    }
}

