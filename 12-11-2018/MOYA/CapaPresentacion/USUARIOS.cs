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
    public partial class USUARIOS : Form
    {
        public USUARIOS()
        {
            InitializeComponent();
        }
        public SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mostrar(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("MostrarUsuarios", Conexion);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {
            textusuario.Focus();
            mostrar(dataGridView1);

        }

        public void limpiar() {
            textusuario.Text = "";
            textnombre.Text = "";
            textapellidos.Text = "";
            comboboxcargo.Text = "";
            textcontraseña.Text = "";
        
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {

            if (textusuario.Text == "" || textnombre.Text == "" || textapellidos.Text == "" || comboboxcargo.Text == "" || textcontraseña.Text == "")
            {
                MessageBox.Show("LLene todos los campos porfavor","",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                if (MessageBox.Show("Desea agregar un nuevo acceso?", "", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Conexion.Open();
                        //PROCEDIMNIENTO
                        SqlCommand comando = new SqlCommand("AgregarUsuario", Conexion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Usuario", Convert.ToString(textusuario.Text));
                        comando.Parameters.AddWithValue("@Nombres", Convert.ToString(textnombre.Text));
                        comando.Parameters.AddWithValue("@Apellidos", Convert.ToString(textapellidos.Text));
                        comando.Parameters.AddWithValue("@Cargo", Convert.ToString(comboboxcargo.Text));
                        comando.Parameters.AddWithValue("@Contraseña", Convert.ToString(textcontraseña.Text));

                        comando.ExecuteNonQuery();
                        comando.Parameters.Clear();
                        MessageBox.Show("Datos agregados con exito");
                        mostrar(dataGridView1);
                        limpiar();
                        Conexion.Close();
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Este nombre de usuario ya existe","",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el acceso?", "", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = (dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                if (Convert.ToInt32(id) == 58)
                {
                    MessageBox.Show("Este administrador no puede ser eliminado","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    Conexion.Open();
                    SqlCommand comando = new SqlCommand("EliminarUsuario", Conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@ID", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                    MessageBox.Show("Datos eliminados");
                    limpiar();
                    mostrar(dataGridView1);
                    Conexion.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

    }
}
