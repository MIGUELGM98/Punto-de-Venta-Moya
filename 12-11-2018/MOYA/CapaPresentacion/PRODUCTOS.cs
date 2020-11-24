using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class PRODUCTOS : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string ID = null;
        private bool Editar = false;
        public PRODUCTOS()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textcodigo.Focus();
            MostrarProductos();
        }
        
        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }
        private void limpiarForm()
        {
            textcodigo.Clear();
            textnombre.Text = "";
            textprecio.Clear();
        }

        private void iconocerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textcodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                textnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textprecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila completa porfavor");
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Desea eliminar el producto seleccionado?", "", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    objetoCN.EliminarProducto(ID);
                    //MessageBox.Show("Eliminado correctamente");
                    MostrarProductos();
                }
            }
            else
                MessageBox.Show("Seleccione la fila completa porfavor","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {           
                if (Editar == false)
                {
                    if (MessageBox.Show("Desea agregar un nuevo producto?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {                        
                            try
                            {
                                if (textcodigo.Text == "" || textnombre.Text == "" || textprecio.Text == "")
                                 {
                                     MessageBox.Show("Llene todos los campos porfavor","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                   }
                                else
                                {
                                    objetoCN.InsertarProduc(textcodigo.Text, textnombre.Text, textprecio.Text);
                                    //MessageBox.Show("Datos registrados con exito");
                                    MostrarProductos();
                                    limpiarForm();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Este codigo ya existe");
                            }                        
                    }
                }
                if (Editar == true)
                {
                    if (MessageBox.Show("Desea actualizar los datos?", "", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    try
                    {

                        objetoCN.EditarProduc(textcodigo.Text, textnombre.Text, textprecio.Text, ID);
                       // MessageBox.Show("Datos actualizados con exito");
                        MostrarProductos();
                        limpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Llene todos los campos porfavor","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    }
                }
            }
        

        private void textcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



       
       
    }
}
