namespace IL_MENDO.ABM_Cliente
{
    partial class modificar_cliente
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
            this.button2 = new System.Windows.Forms.Button();
            this.guardarNuevosDatos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tarifas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.importeMinimo = new System.Windows.Forms.TextBox();
            this.tarifaRepartos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guardarNuevosDatos
            // 
            this.guardarNuevosDatos.BackColor = System.Drawing.SystemColors.Menu;
            this.guardarNuevosDatos.Location = new System.Drawing.Point(328, 355);
            this.guardarNuevosDatos.Name = "guardarNuevosDatos";
            this.guardarNuevosDatos.Size = new System.Drawing.Size(165, 52);
            this.guardarNuevosDatos.TabIndex = 4;
            this.guardarNuevosDatos.Text = "GUARDAR NUEVOS DATOS";
            this.guardarNuevosDatos.UseVisualStyleBackColor = false;
            this.guardarNuevosDatos.Click += new System.EventHandler(this.guardarNuevosDatos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tarifas);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.importeMinimo);
            this.groupBox1.Controls.Add(this.tarifaRepartos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(215, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 233);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.Honeydew;
            this.nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(27, 56);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(142, 27);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(257, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "VER TARIFA";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tarifas
            // 
            this.tarifas.BackColor = System.Drawing.Color.Honeydew;
            this.tarifas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifas.FormattingEnabled = true;
            this.tarifas.Location = new System.Drawing.Point(27, 182);
            this.tarifas.Name = "tarifas";
            this.tarifas.Size = new System.Drawing.Size(211, 27);
            this.tarifas.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tarifa larga distancia";
            // 
            // importeMinimo
            // 
            this.importeMinimo.BackColor = System.Drawing.Color.Honeydew;
            this.importeMinimo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeMinimo.Location = new System.Drawing.Point(209, 117);
            this.importeMinimo.Name = "importeMinimo";
            this.importeMinimo.Size = new System.Drawing.Size(142, 27);
            this.importeMinimo.TabIndex = 7;
            // 
            // tarifaRepartos
            // 
            this.tarifaRepartos.BackColor = System.Drawing.Color.Honeydew;
            this.tarifaRepartos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifaRepartos.Location = new System.Drawing.Point(27, 117);
            this.tarifaRepartos.Name = "tarifaRepartos";
            this.tarifaRepartos.Size = new System.Drawing.Size(142, 27);
            this.tarifaRepartos.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tarifa de repartos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Importe minimo";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Honeydew;
            this.descripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(209, 56);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(142, 27);
            this.descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente descripcion";
            // 
            // clientes
            // 
            this.clientes.BackColor = System.Drawing.Color.Honeydew;
            this.clientes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes.FormattingEnabled = true;
            this.clientes.Location = new System.Drawing.Point(328, 80);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(172, 27);
            this.clientes.TabIndex = 2;
            this.clientes.SelectedIndexChanged += new System.EventHandler(this.clientes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione un cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CUIDADO: Si vas a ingresar un numero decimal, acordate de usar el PUNTO, y NO la " +
    "COMA.";
            // 
            // modificar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guardarNuevosDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Name = "modificar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.moficar_cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button guardarNuevosDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tarifas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox importeMinimo;
        private System.Windows.Forms.TextBox tarifaRepartos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;

    }
}