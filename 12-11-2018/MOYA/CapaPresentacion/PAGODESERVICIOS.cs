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
    public partial class PAGODESERVICIOS : Form
    {
        CN_Pagos objetoCN = new CN_Pagos();
        private string ID = null;
        private bool Editar = false;
        public PAGODESERVICIOS()
        {
            InitializeComponent();
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PAGODESERVICIOS_Load(object sender, EventArgs e)
        {
            textdescripcion.Focus();
            MostrarPagos();
        }
        private void MostrarPagos()
        {
            CN_Pagos objeto = new CN_Pagos();
            dataGridView1.DataSource = objeto.MostrarPagos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton registrar
            if (Editar == false)
            {
                if (MessageBox.Show("Desea agregar un nuevo pago?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        objetoCN.Nuevopago(textdescripcion.Text, textmonto.Text, DateTime.Now.ToShortDateString());
                       // MessageBox.Show("Datos registrados con exito");
                        MostrarPagos();
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("LLene todos los campos porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            if (Editar == true)
            {
                if (MessageBox.Show("Desea actualizar los datos del pago?", "", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        objetoCN.EditarPago(textdescripcion.Text, textmonto.Text, ID, DateTime.Now.ToShortDateString());
                       // MessageBox.Show("Datos actualizados con exito");
                        MostrarPagos();
                        limpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("LLene todos los campos porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textdescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                textmonto.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione la fila completa porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {           
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Desea eliminar el pago?", "", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    ID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    objetoCN.EliminarPago(ID);
                   // MessageBox.Show("Eliminado correctamente");
                    MostrarPagos();
                    }
                }
                else
                    MessageBox.Show("Seleccione la fila completa porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void limpiarForm()
        {
            textdescripcion.Clear();
            textmonto.Clear();
        }

        private void textmonto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        }
         
       
    }

