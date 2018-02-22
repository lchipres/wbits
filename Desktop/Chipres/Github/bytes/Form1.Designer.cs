namespace bytes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nivelBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.bttnProcesar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFecLec = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnAjustarFecha = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSens1 = new System.Windows.Forms.Label();
            this.lblSens2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtFecOrig = new System.Windows.Forms.TextBox();
            this.txtFecDes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // nivelBar
            // 
            this.nivelBar.Location = new System.Drawing.Point(122, 73);
            this.nivelBar.Maximum = 3;
            this.nivelBar.Name = "nivelBar";
            this.nivelBar.Size = new System.Drawing.Size(98, 37);
            this.nivelBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(16, 30);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 3;
            // 
            // bttnProcesar
            // 
            this.bttnProcesar.Location = new System.Drawing.Point(122, 27);
            this.bttnProcesar.Name = "bttnProcesar";
            this.bttnProcesar.Size = new System.Drawing.Size(75, 23);
            this.bttnProcesar.TabIndex = 4;
            this.bttnProcesar.Text = "Procesar";
            this.bttnProcesar.UseVisualStyleBackColor = true;
            this.bttnProcesar.Click += new System.EventHandler(this.bttnProcesar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección de movimiento";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(246, 74);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(22, 13);
            this.lblDir.TabIndex = 6;
            this.lblDir.Text = "NA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sensores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de lectura";
            // 
            // lblFecLec
            // 
            this.lblFecLec.AutoSize = true;
            this.lblFecLec.Location = new System.Drawing.Point(104, 134);
            this.lblFecLec.Name = "lblFecLec";
            this.lblFecLec.Size = new System.Drawing.Size(37, 13);
            this.lblFecLec.TabIndex = 11;
            this.lblFecLec.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFecDes);
            this.groupBox1.Controls.Add(this.txtFecOrig);
            this.groupBox1.Controls.Add(this.bttnAjustarFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 149);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Segunda parte";
            // 
            // bttnAjustarFecha
            // 
            this.bttnAjustarFecha.Location = new System.Drawing.Point(62, 46);
            this.bttnAjustarFecha.Name = "bttnAjustarFecha";
            this.bttnAjustarFecha.Size = new System.Drawing.Size(75, 23);
            this.bttnAjustarFecha.TabIndex = 2;
            this.bttnAjustarFecha.Text = "Ajustar fecha";
            this.bttnAjustarFecha.UseVisualStyleBackColor = true;
            this.bttnAjustarFecha.Click += new System.EventHandler(this.bttnAjustarFecha_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(63, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblSens1
            // 
            this.lblSens1.AutoSize = true;
            this.lblSens1.Location = new System.Drawing.Point(10, 121);
            this.lblSens1.Name = "lblSens1";
            this.lblSens1.Size = new System.Drawing.Size(54, 13);
            this.lblSens1.TabIndex = 15;
            this.lblSens1.Text = "1 Inactivo";
            // 
            // lblSens2
            // 
            this.lblSens2.AutoSize = true;
            this.lblSens2.Location = new System.Drawing.Point(60, 121);
            this.lblSens2.Name = "lblSens2";
            this.lblSens2.Size = new System.Drawing.Size(54, 13);
            this.lblSens2.TabIndex = 16;
            this.lblSens2.Text = "2 Inactivo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(274, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // txtFecOrig
            // 
            this.txtFecOrig.Location = new System.Drawing.Point(50, 20);
            this.txtFecOrig.Name = "txtFecOrig";
            this.txtFecOrig.Size = new System.Drawing.Size(100, 20);
            this.txtFecOrig.TabIndex = 18;
            // 
            // txtFecDes
            // 
            this.txtFecDes.Location = new System.Drawing.Point(50, 75);
            this.txtFecDes.Name = "txtFecDes";
            this.txtFecDes.Size = new System.Drawing.Size(100, 20);
            this.txtFecDes.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 338);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblSens2);
            this.Controls.Add(this.lblSens1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecLec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnProcesar);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nivelBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar nivelBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button bttnProcesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFecLec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnAjustarFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSens1;
        private System.Windows.Forms.Label lblSens2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtFecDes;
        private System.Windows.Forms.TextBox txtFecOrig;
    }
}

