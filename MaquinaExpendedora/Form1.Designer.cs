namespace MaquinaExpendedora
{
    partial class FrmMaquina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDinero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picSuavicrema = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picSabritas = new System.Windows.Forms.PictureBox();
            this.picPocky = new System.Windows.Forms.PictureBox();
            this.picCoca = new System.Windows.Forms.PictureBox();
            this.btnDinero = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuavicrema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSabritas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPocky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maquina Expendedora";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::MaquinaExpendedora.Properties.Resources.Captura_de_pantalla_2026_05_01_215036;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(124, 634);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 80);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(447, 136);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(164, 16);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado: Esperando dinero";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.ForeColor = System.Drawing.Color.White;
            this.lblDinero.Location = new System.Drawing.Point(447, 181);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(67, 16);
            this.lblDinero.TabIndex = 3;
            this.lblDinero.Text = "Dinero: $0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::MaquinaExpendedora.Properties.Resources.Captura_de_pantalla_2026_05_01_215036;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picSuavicrema);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picSabritas);
            this.panel1.Controls.Add(this.picPocky);
            this.panel1.Controls.Add(this.picCoca);
            this.panel1.Location = new System.Drawing.Point(30, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 522);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(248, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(248, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "20";
            // 
            // picSuavicrema
            // 
            this.picSuavicrema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSuavicrema.Image = global::MaquinaExpendedora.Properties.Resources.Captura_de_pantalla_2026_05_01_2059551;
            this.picSuavicrema.Location = new System.Drawing.Point(208, 51);
            this.picSuavicrema.Name = "picSuavicrema";
            this.picSuavicrema.Size = new System.Drawing.Size(106, 159);
            this.picSuavicrema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSuavicrema.TabIndex = 2;
            this.picSuavicrema.TabStop = false;
            this.picSuavicrema.Click += new System.EventHandler(this.picSuavicrema_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "20";
            // 
            // picSabritas
            // 
            this.picSabritas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSabritas.Image = global::MaquinaExpendedora.Properties.Resources.Captura_de_pantalla_2026_05_01_213343;
            this.picSabritas.Location = new System.Drawing.Point(208, 269);
            this.picSabritas.Name = "picSabritas";
            this.picSabritas.Size = new System.Drawing.Size(106, 151);
            this.picSabritas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSabritas.TabIndex = 3;
            this.picSabritas.TabStop = false;
            this.picSabritas.Click += new System.EventHandler(this.picSabritas_Click);
            // 
            // picPocky
            // 
            this.picPocky.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPocky.Image = global::MaquinaExpendedora.Properties.Resources.Captura_de_pantalla_2026_05_01_205828;
            this.picPocky.Location = new System.Drawing.Point(39, 269);
            this.picPocky.Name = "picPocky";
            this.picPocky.Size = new System.Drawing.Size(113, 151);
            this.picPocky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPocky.TabIndex = 2;
            this.picPocky.TabStop = false;
            this.picPocky.Click += new System.EventHandler(this.picPocky_Click);
            // 
            // picCoca
            // 
            this.picCoca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCoca.Image = global::MaquinaExpendedora.Properties.Resources.Captura_de_pantalla_2026_05_01_2136271;
            this.picCoca.Location = new System.Drawing.Point(39, 51);
            this.picCoca.Name = "picCoca";
            this.picCoca.Size = new System.Drawing.Size(113, 159);
            this.picCoca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoca.TabIndex = 2;
            this.picCoca.TabStop = false;
            this.picCoca.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnDinero
            // 
            this.btnDinero.Location = new System.Drawing.Point(471, 316);
            this.btnDinero.Name = "btnDinero";
            this.btnDinero.Size = new System.Drawing.Size(117, 23);
            this.btnDinero.TabIndex = 5;
            this.btnDinero.Text = "Insertar dinero";
            this.btnDinero.UseVisualStyleBackColor = true;
            this.btnDinero.Click += new System.EventHandler(this.btnDinero_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(471, 368);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(117, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(447, 218);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(164, 77);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Selecciona un producto";
            // 
            // salir
            // 
            this.salir.AutoSize = true;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(640, 9);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(19, 22);
            this.salir.TabIndex = 9;
            this.salir.Text = "x";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // FrmMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(671, 753);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnDinero);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaquina";
            this.Text = "Máquina Expendedora";
            this.Load += new System.EventHandler(this.FrmMaquina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSuavicrema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSabritas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPocky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCoca;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPocky;
        private System.Windows.Forms.PictureBox picSabritas;
        private System.Windows.Forms.PictureBox picSuavicrema;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Button btnDinero;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

