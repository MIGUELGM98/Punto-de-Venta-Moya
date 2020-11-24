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

namespace CapaPresentacion
{
    public partial class Aceptar : Form
    {
        public Aceptar()
        {
            InitializeComponent();
        }
        public SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");

        
        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textusuario.Text;
            pass = textcontraseña.Text;
            SqlDataReader leer;
            Conexion.Open();
            SqlCommand comando = new SqlCommand("Iniciarsesion", Conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", user);
            comando.Parameters.AddWithValue("@Password", pass);
            leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                textusuario.Focus();
                textusuario.Text = "";
                textcontraseña.Text = "";
            }
            Conexion.Close();

        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Aceptar_Load(object sender, EventArgs e)
        {
            textcontraseña.UseSystemPasswordChar = true;
        }
    }
}
