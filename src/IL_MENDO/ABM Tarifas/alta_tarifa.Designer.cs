namespace IL_MENDO.ABM_Tarifas
{
    partial class alta_tarifa
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
            this.importeMinimo = new System.Windows.Forms.TextBox();
            this.liquidar = new System.Windows.Forms.Button();
            this.tarifaRepartos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // importeMinimo
            // 
            this.importeMinimo.BackColor = System.Drawing.Color.Honeydew;
            this.importeMinimo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeMinimo.Location = new System.Drawing.Point(356, 257);
            this.importeMinimo.Name = "importeMinimo";
            this.importeMinimo.Size = new System.Drawing.Size(142, 27);
            this.importeMinimo.TabIndex = 63;
            // 
            // liquidar
            // 
            this.liquidar.BackColor = System.Drawing.SystemColors.Menu;
            this.liquidar.Location = new System.Drawing.Point(347, 318);
            this.liquidar.Name = "liquidar";
            this.liquidar.Size = new System.Drawing.Size(165, 52);
            this.liquidar.TabIndex = 62;
            this.liquidar.Text = "CARGAR NUEVA TARIFA";
            this.liquidar.UseVisualStyleBackColor = false;
            // 
            // tarifaRepartos
            // 
            this.tarifaRepartos.BackColor = System.Drawing.Color.Honeydew;
            this.tarifaRepartos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifaRepartos.Location = new System.Drawing.Point(356, 187);
            this.tarifaRepartos.Name = "tarifaRepartos";
            this.tarifaRepartos.Size = new System.Drawing.Size(142, 27);
            this.tarifaRepartos.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tarifa de repartos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Importe minimo";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Honeydew;
            this.descripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(356, 118);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(142, 27);
            this.descripcion.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tarifa descripcion";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 56;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alta_tarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.importeMinimo);
            this.Controls.Add(this.liquidar);
            this.Controls.Add(this.tarifaRepartos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "alta_tarifa";
            this.Text = "Alta Tarifa";
            this.Load += new System.EventHandler(this.alta_tarifa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox importeMinimo;
        private System.Windows.Forms.Button liquidar;
        private System.Windows.Forms.TextBox tarifaRepartos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}