namespace IL_MENDO.Nuevo_Gasto
{
    partial class nuevo_gasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevo_gasto));
            this.costo = new System.Windows.Forms.TextBox();
            this.liquidar = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.camiones = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // costo
            // 
            this.costo.BackColor = System.Drawing.Color.Honeydew;
            this.costo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo.Location = new System.Drawing.Point(356, 272);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(142, 27);
            this.costo.TabIndex = 69;
            this.costo.TextChanged += new System.EventHandler(this.costo_TextChanged);
            // 
            // liquidar
            // 
            this.liquidar.BackColor = System.Drawing.SystemColors.Menu;
            this.liquidar.Location = new System.Drawing.Point(347, 327);
            this.liquidar.Name = "liquidar";
            this.liquidar.Size = new System.Drawing.Size(165, 52);
            this.liquidar.TabIndex = 68;
            this.liquidar.Text = "CARGAR NUEVA TARIFA";
            this.liquidar.UseVisualStyleBackColor = false;
            this.liquidar.Click += new System.EventHandler(this.liquidar_Click);
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.Honeydew;
            this.tipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(356, 148);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(142, 27);
            this.tipo.TabIndex = 67;
            this.tipo.TextChanged += new System.EventHandler(this.tipo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Tipo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Costo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 64;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // camiones
            // 
            this.camiones.BackColor = System.Drawing.Color.Honeydew;
            this.camiones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camiones.FormattingEnabled = true;
            this.camiones.Location = new System.Drawing.Point(356, 85);
            this.camiones.Name = "camiones";
            this.camiones.Size = new System.Drawing.Size(142, 27);
            this.camiones.TabIndex = 71;
            this.camiones.SelectedIndexChanged += new System.EventHandler(this.camiones_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Camion";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 72;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fecha
            // 
            this.fecha.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(355, 207);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(142, 26);
            this.fecha.TabIndex = 73;
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            // 
            // nuevo_gasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.camiones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.liquidar);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "nuevo_gasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Gasto";
            this.Load += new System.EventHandler(this.nuevo_gasto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Button liquidar;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox camiones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha;
    }
}