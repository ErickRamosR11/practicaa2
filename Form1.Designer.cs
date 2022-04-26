namespace practicaa2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.nombre = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paterno = new System.Windows.Forms.TextBox();
            this.materno = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.colonia = new System.Windows.Forms.TextBox();
            this.calle = new System.Windows.Forms.TextBox();
            this.consultar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(189, 60);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(117, 23);
            this.nombre.TabIndex = 0;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(174, 270);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(117, 67);
            this.guardar.TabIndex = 1;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Calle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Colonia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Numero Casa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha Creacion:";
            // 
            // paterno
            // 
            this.paterno.Location = new System.Drawing.Point(189, 96);
            this.paterno.Name = "paterno";
            this.paterno.Size = new System.Drawing.Size(117, 23);
            this.paterno.TabIndex = 11;
            // 
            // materno
            // 
            this.materno.Location = new System.Drawing.Point(189, 129);
            this.materno.Name = "materno";
            this.materno.Size = new System.Drawing.Size(117, 23);
            this.materno.TabIndex = 12;
            // 
            // clave
            // 
            this.clave.Location = new System.Drawing.Point(189, 163);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(117, 23);
            this.clave.TabIndex = 13;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(498, 129);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(115, 23);
            this.numero.TabIndex = 14;
            // 
            // colonia
            // 
            this.colonia.Location = new System.Drawing.Point(498, 93);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(115, 23);
            this.colonia.TabIndex = 15;
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(498, 55);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(115, 23);
            this.calle.TabIndex = 16;
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(435, 270);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(124, 67);
            this.consultar.TabIndex = 17;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(498, 163);
            this.fecha.Name = "fecha";
            this.fecha.PlaceholderText = "Ex: AAAA-MM-DD";
            this.fecha.Size = new System.Drawing.Size(115, 23);
            this.fecha.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.colonia);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.materno);
            this.Controls.Add(this.paterno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySqlConnector.MySqlCommand mySqlCommand1;
        private TextBox nombre;
        private Button guardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox paterno;
        private TextBox materno;
        private TextBox clave;
        private TextBox numero;
        private TextBox colonia;
        private TextBox calle;
        private Button consultar;
        private TextBox fecha;
    }
}