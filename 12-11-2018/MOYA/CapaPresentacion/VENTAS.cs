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
    public partial class VENTAS : Form
    {
        public SqlConnection Conexion = new SqlConnection("Server=MIGUELGONZALEZ\\SQLEXPRESS;DataBase=MOYA2;Integrated Security=true");

        public VENTAS()
        {
            InitializeComponent();
            textBoxcodigo.Focus();
            
        }
        
        private void iconocerrar_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

 

        private void textBoxcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
             
        }
        int sumatotal = 0;
        int total;
        private void solonumeros(KeyPressEventArgs e)
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
        private void textBoxcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
            Conexion.Open();

                
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (textBoxcantidad.Text == "")
                    {
                        MessageBox.Show("Ingrese una cantidad","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (Convert.ToInt32(textBoxcantidad.Text) > 0)
                        {
                            try
                            {
                                SqlDataReader leer;
                                DataGridViewRow fila = new DataGridViewRow();
                                String cadena = "select * from Productos where Codigo=" + textBoxcodigo.Text;
                                fila.CreateCells(dataGridView1);
                                SqlCommand da = new SqlCommand(cadena, Conexion);
                                leer = da.ExecuteReader();
                                Boolean verificar = false;
                                while (leer.Read())
                                {
                                    fila.Cells[0].Value = leer.GetValue(1);
                                    fila.Cells[1].Value = leer.GetString(2);
                                    fila.Cells[2].Value = leer.GetValue(3);
                                    fila.Cells[3].Value = textBoxcantidad.Text;
                                    int precio = Convert.ToInt32(fila.Cells[2].Value);
                                    int boxcantidad = Convert.ToInt32(textBoxcantidad.Text);
                                    total = precio * boxcantidad;
                                    fila.Cells[4].Value = total;
                                    sumatotal = sumatotal + total;
                                    dataGridView1.Rows.Add(fila);

                                    labeldinero.Text = sumatotal.ToString() + ".00";
                                    lblcambio.Text = "";
                                    efectivo.Text = "";
                                    if (Convert.ToString(fila.Cells[0].Value).Equals(textBoxcodigo.Text))
                                    {
                                        verificar = true;

                                    }
                                }
                                if (verificar == false)
                                {
                                    MessageBox.Show("Este codigo no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                textBoxcantidad.Text = "";
                                textBoxcodigo.Text = "";
                                textBoxcodigo.Focus();
                            }
                            catch (Exception es)
                            {
                                MessageBox.Show("Realize bien la operacion");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingrese cantidades mayores a 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxcantidad.Text = "";
                            textBoxcodigo.Text = "";
                            textBoxcodigo.Focus();
                        }
                    }

            }
                Conexion.Close();
        }
        
        Boolean checar = true;
        private void efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
            string longitud = efectivo.Text;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Convert.ToInt32(efectivo.Text) == 99999999)
                {
                    MessageBox.Show("Cantidad muy grande, intente de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (labeldinero.Text == "0.00")
                    {
                        MessageBox.Show("No se ah realizado una venta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        efectivo.Text = "";
                    }
                    else
                    {
                        int pago, feria;
                        pago = Convert.ToInt32(efectivo.Text);
                        if (pago >= sumatotal)
                        {
                            feria = pago - sumatotal;
                            lblcambio.Text = feria.ToString();
                            checar = true;
                        }
                        else
                        {
                            lblcambio.Text = "Saldo insuficiente";
                            checar = false;
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool es = true;
            if (labeldinero.Text == "0.00")
            {
                MessageBox.Show("No ha realizado ninguna venta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                es = false;
            }
            else if (lblcambio.Text == "") {
                MessageBox.Show("Efectue el pago porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checar == false || efectivo.Text == "" && es == true)
                {
                    MessageBox.Show("Porfavor realize primero el pago", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    dataGridView1.Rows.Clear();
                    lblcambio.Text = "";
                    labeldinero.Text = "0.00";

                    efectivo.Text = "";

                    Conexion.Open();
                    try
                    {
                        SqlCommand agregar = new SqlCommand("RealizarVenta", Conexion);
                        agregar.CommandType = CommandType.StoredProcedure;
                        agregar.Parameters.AddWithValue("@Total", sumatotal);
                        agregar.Parameters.AddWithValue("@Fecha", DateTime.Now.ToShortDateString());
                        agregar.ExecuteNonQuery();
                        agregar.Parameters.Clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);

                    }
                    Conexion.Close();
                    sumatotal = 0;
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0){
                total = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Total"].Value.ToString());
                sumatotal = sumatotal - total;
                labeldinero.Text = sumatotal.ToString() + ".00";
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                efectivo.Text = "";
                lblcambio.Text = "";
               
            }
            else
            {
                MessageBox.Show("Agrege primero un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            textBoxcodigo.Focus();
        }

        private void textBoxcodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void textBoxcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcodigo_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }
    

