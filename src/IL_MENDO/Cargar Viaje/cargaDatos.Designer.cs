namespace IL_MENDO.Cargar_Viaje
{
    partial class cargaDatos
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
            this.choferes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kilometros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.remito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toneladas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.liquidar = new System.Windows.Forms.Button();
            this.descarga = new System.Windows.Forms.TextBox();
            this.carga = new System.Windows.Forms.TextBox();
            this.clientes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // choferes
            // 
            this.choferes.BackColor = System.Drawing.Color.Honeydew;
            this.choferes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choferes.FormattingEnabled = true;
            this.choferes.Location = new System.Drawing.Point(176, 46);
            this.choferes.Name = "choferes";
            this.choferes.Size = new System.Drawing.Size(142, 27);
            this.choferes.TabIndex = 5;
            this.choferes.SelectedIndexChanged += new System.EventHandler(this.camionesCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chofer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kilometros
            // 
            this.kilometros.BackColor = System.Drawing.Color.Honeydew;
            this.kilometros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometros.Location = new System.Drawing.Point(10, 115);
            this.kilometros.Name = "kilometros";
            this.kilometros.Size = new System.Drawing.Size(142, 27);
            this.kilometros.TabIndex = 7;
            this.kilometros.TextChanged += new System.EventHandler(this.apellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kilometros";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(10, 45);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(142, 26);
            this.fecha.TabIndex = 3;
            // 
            // remito
            // 
            this.remito.BackColor = System.Drawing.Color.Honeydew;
            this.remito.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remito.Location = new System.Drawing.Point(10, 256);
            this.remito.Name = "remito";
            this.remito.Size = new System.Drawing.Size(142, 27);
            this.remito.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nro de Remito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lugar de carga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lugar de descarga";
            // 
            // toneladas
            // 
            this.toneladas.BackColor = System.Drawing.Color.Honeydew;
            this.toneladas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toneladas.Location = new System.Drawing.Point(10, 184);
            this.toneladas.Name = "toneladas";
            this.toneladas.Size = new System.Drawing.Size(142, 27);
            this.toneladas.TabIndex = 11;
            this.toneladas.TextChanged += new System.EventHandler(this.toneladas_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Toneladas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // liquidar
            // 
            this.liquidar.BackColor = System.Drawing.SystemColors.Menu;
            this.liquidar.Location = new System.Drawing.Point(314, 381);
            this.liquidar.Name = "liquidar";
            this.liquidar.Size = new System.Drawing.Size(165, 52);
            this.liquidar.TabIndex = 18;
            this.liquidar.Text = "CARGAR VIAJE";
            this.liquidar.UseVisualStyleBackColor = false;
            this.liquidar.Click += new System.EventHandler(this.liquidar_Click);
            // 
            // descarga
            // 
            this.descarga.BackColor = System.Drawing.Color.Honeydew;
            this.descarga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descarga.Location = new System.Drawing.Point(176, 256);
            this.descarga.Name = "descarga";
            this.descarga.Size = new System.Drawing.Size(142, 27);
            this.descarga.TabIndex = 17;
            // 
            // carga
            // 
            this.carga.BackColor = System.Drawing.Color.Honeydew;
            this.carga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carga.Location = new System.Drawing.Point(176, 184);
            this.carga.Name = "carga";
            this.carga.Size = new System.Drawing.Size(142, 27);
            this.carga.TabIndex = 13;
            // 
            // clientes
            // 
            this.clientes.BackColor = System.Drawing.Color.Honeydew;
            this.clientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes.FormattingEnabled = true;
            this.clientes.Location = new System.Drawing.Point(176, 116);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(142, 27);
            this.clientes.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cliente";
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.Honeydew;
            this.tipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(408, 31);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(142, 27);
            this.tipo.TabIndex = 1;
            this.tipo.SelectedIndexChanged += new System.EventHandler(this.tipo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(238, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seleccione tipo de viaje: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kilometros);
            this.groupBox1.Controls.Add(this.clientes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.choferes);
            this.groupBox1.Controls.Add(this.descarga);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.remito);
            this.groupBox1.Controls.Add(this.toneladas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(232, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 300);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del viaje";
            // 
            // cargaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.liquidar);
            this.Name = "cargaDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Nuevo Reparto";
            this.Load += new System.EventHandler(this.reparto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choferes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kilometros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox remito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox toneladas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button liquidar;
        private System.Windows.Forms.TextBox descarga;
        private System.Windows.Forms.TextBox carga;
        private System.Windows.Forms.ComboBox clientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}