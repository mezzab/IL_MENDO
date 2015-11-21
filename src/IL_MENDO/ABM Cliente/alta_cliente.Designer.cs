namespace IL_MENDO.ABM_Cliente
{
    partial class alta_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alta_cliente));
            this.button2 = new System.Windows.Forms.Button();
            this.importeMinimo = new System.Windows.Forms.TextBox();
            this.cargarNuevoCliente = new System.Windows.Forms.Button();
            this.tarifaRepartos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tarifas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // importeMinimo
            // 
            this.importeMinimo.BackColor = System.Drawing.Color.Honeydew;
            this.importeMinimo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeMinimo.Location = new System.Drawing.Point(420, 172);
            this.importeMinimo.Name = "importeMinimo";
            this.importeMinimo.Size = new System.Drawing.Size(142, 27);
            this.importeMinimo.TabIndex = 7;
            this.importeMinimo.TextChanged += new System.EventHandler(this.importeMinimo_TextChanged);
            // 
            // cargarNuevoCliente
            // 
            this.cargarNuevoCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.cargarNuevoCliente.Location = new System.Drawing.Point(314, 296);
            this.cargarNuevoCliente.Name = "cargarNuevoCliente";
            this.cargarNuevoCliente.Size = new System.Drawing.Size(165, 52);
            this.cargarNuevoCliente.TabIndex = 11;
            this.cargarNuevoCliente.Text = "CARGAR NUEVO CLIENTE";
            this.cargarNuevoCliente.UseVisualStyleBackColor = false;
            this.cargarNuevoCliente.Click += new System.EventHandler(this.liquidar_Click);
            // 
            // tarifaRepartos
            // 
            this.tarifaRepartos.BackColor = System.Drawing.Color.Honeydew;
            this.tarifaRepartos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifaRepartos.Location = new System.Drawing.Point(238, 172);
            this.tarifaRepartos.Name = "tarifaRepartos";
            this.tarifaRepartos.Size = new System.Drawing.Size(142, 27);
            this.tarifaRepartos.TabIndex = 5;
            this.tarifaRepartos.TextChanged += new System.EventHandler(this.tarifaRepartos_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 150);
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
            this.label5.Location = new System.Drawing.Point(416, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Importe minimo";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Honeydew;
            this.descripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(420, 111);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(142, 27);
            this.descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente descripcion";
            // 
            // tarifas
            // 
            this.tarifas.BackColor = System.Drawing.Color.Honeydew;
            this.tarifas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifas.FormattingEnabled = true;
            this.tarifas.Location = new System.Drawing.Point(238, 237);
            this.tarifas.Name = "tarifas";
            this.tarifas.Size = new System.Drawing.Size(211, 27);
            this.tarifas.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(234, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tarifa larga distancia";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(468, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "VER TARIFA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.Honeydew;
            this.nombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(238, 111);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(142, 27);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente nombre";
            // 
            // alta_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarifas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.importeMinimo);
            this.Controls.Add(this.cargarNuevoCliente);
            this.Controls.Add(this.tarifaRepartos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alta_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Cliente";
            this.Load += new System.EventHandler(this.alta_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox importeMinimo;
        private System.Windows.Forms.Button cargarNuevoCliente;
        private System.Windows.Forms.TextBox tarifaRepartos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tarifas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
    }
}