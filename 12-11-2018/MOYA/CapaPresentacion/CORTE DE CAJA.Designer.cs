namespace CapaPresentacion
{
    partial class CORTE_DE_CAJA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CORTE_DE_CAJA));
            this.panelcortedecaja = new System.Windows.Forms.Panel();
            this.iconocerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dinerototal = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalpagos = new System.Windows.Forms.Label();
            this.numegresos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalventas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numventas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelcortedecaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcortedecaja
            // 
            this.panelcortedecaja.Controls.Add(this.iconocerrar);
            this.panelcortedecaja.Controls.Add(this.button1);
            this.panelcortedecaja.Controls.Add(this.label9);
            this.panelcortedecaja.Controls.Add(this.dinerototal);
            this.panelcortedecaja.Controls.Add(this.fecha);
            this.panelcortedecaja.Controls.Add(this.label8);
            this.panelcortedecaja.Controls.Add(this.totalpagos);
            this.panelcortedecaja.Controls.Add(this.numegresos);
            this.panelcortedecaja.Controls.Add(this.label3);
            this.panelcortedecaja.Controls.Add(this.label5);
            this.panelcortedecaja.Controls.Add(this.totalventas);
            this.panelcortedecaja.Controls.Add(this.label2);
            this.panelcortedecaja.Controls.Add(this.numventas);
            this.panelcortedecaja.Controls.Add(this.label1);
            this.panelcortedecaja.Controls.Add(this.label4);
            this.panelcortedecaja.Location = new System.Drawing.Point(1, 2);
            this.panelcortedecaja.Name = "panelcortedecaja";
            this.panelcortedecaja.Size = new System.Drawing.Size(1036, 589);
            this.panelcortedecaja.TabIndex = 0;
            // 
            // iconocerrar
            // 
            this.iconocerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconocerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconocerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconocerrar.Image")));
            this.iconocerrar.Location = new System.Drawing.Point(991, 10);
            this.iconocerrar.Name = "iconocerrar";
            this.iconocerrar.Size = new System.Drawing.Size(35, 20);
            this.iconocerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconocerrar.TabIndex = 39;
            this.iconocerrar.TabStop = false;
            this.iconocerrar.Click += new System.EventHandler(this.iconocerrar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(590, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Realizar corte de caja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(566, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 77);
            this.label9.TabIndex = 37;
            this.label9.Text = "$";
            // 
            // dinerototal
            // 
            this.dinerototal.AutoSize = true;
            this.dinerototal.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dinerototal.ForeColor = System.Drawing.Color.White;
            this.dinerototal.Location = new System.Drawing.Point(641, 247);
            this.dinerototal.Name = "dinerototal";
            this.dinerototal.Size = new System.Drawing.Size(69, 77);
            this.dinerototal.TabIndex = 36;
            this.dinerototal.Text = "0";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Location = new System.Drawing.Point(593, 207);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 23);
            this.fecha.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(437, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Egresos del dia";
            // 
            // totalpagos
            // 
            this.totalpagos.AutoSize = true;
            this.totalpagos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpagos.ForeColor = System.Drawing.Color.White;
            this.totalpagos.Location = new System.Drawing.Point(331, 398);
            this.totalpagos.Name = "totalpagos";
            this.totalpagos.Size = new System.Drawing.Size(21, 23);
            this.totalpagos.TabIndex = 33;
            this.totalpagos.Text = "0";
            // 
            // numegresos
            // 
            this.numegresos.AutoSize = true;
            this.numegresos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numegresos.ForeColor = System.Drawing.Color.White;
            this.numegresos.Location = new System.Drawing.Point(331, 342);
            this.numegresos.Name = "numegresos";
            this.numegresos.Size = new System.Drawing.Size(21, 23);
            this.numegresos.TabIndex = 32;
            this.numegresos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total de egresos:               $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Numero total de egresos:";
            // 
            // totalventas
            // 
            this.totalventas.AutoSize = true;
            this.totalventas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalventas.ForeColor = System.Drawing.Color.White;
            this.totalventas.Location = new System.Drawing.Point(331, 278);
            this.totalventas.Name = "totalventas";
            this.totalventas.Size = new System.Drawing.Size(21, 23);
            this.totalventas.TabIndex = 29;
            this.totalventas.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total de ventas:                 $";
            // 
            // numventas
            // 
            this.numventas.AutoSize = true;
            this.numventas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numventas.ForeColor = System.Drawing.Color.White;
            this.numventas.Location = new System.Drawing.Point(331, 207);
            this.numventas.Name = "numventas";
            this.numventas.Size = new System.Drawing.Size(21, 23);
            this.numventas.TabIndex = 27;
            this.numventas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Numero de ventas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(435, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "CORTE DE CAJA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CORTE_DE_CAJA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1038, 592);
            this.Controls.Add(this.panelcortedecaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CORTE_DE_CAJA";
            this.Text = "CORTE_DE_CAJA";
            this.Load += new System.EventHandler(this.CORTE_DE_CAJA_Load);
            this.panelcortedecaja.ResumeLayout(false);
            this.panelcortedecaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconocerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcortedecaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalpagos;
        private System.Windows.Forms.Label numegresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dinerototal;
        private System.Windows.Forms.PictureBox iconocerrar;
    }
}