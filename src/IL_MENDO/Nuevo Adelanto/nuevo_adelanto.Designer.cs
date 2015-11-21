namespace IL_MENDO.Nuevo_Adelanto
{
    partial class nuevo_adelanto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevo_adelanto));
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.choferes = new System.Windows.Forms.ComboBox();
            this.costo = new System.Windows.Forms.TextBox();
            this.liquidar = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(355, 207);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(142, 26);
            this.fecha.TabIndex = 82;
            // 
            // choferes
            // 
            this.choferes.BackColor = System.Drawing.Color.Honeydew;
            this.choferes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choferes.FormattingEnabled = true;
            this.choferes.Location = new System.Drawing.Point(356, 85);
            this.choferes.Name = "choferes";
            this.choferes.Size = new System.Drawing.Size(142, 27);
            this.choferes.TabIndex = 80;
            // 
            // costo
            // 
            this.costo.BackColor = System.Drawing.Color.Honeydew;
            this.costo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo.Location = new System.Drawing.Point(356, 272);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(142, 27);
            this.costo.TabIndex = 79;
            // 
            // liquidar
            // 
            this.liquidar.BackColor = System.Drawing.SystemColors.Menu;
            this.liquidar.Location = new System.Drawing.Point(347, 327);
            this.liquidar.Name = "liquidar";
            this.liquidar.Size = new System.Drawing.Size(165, 52);
            this.liquidar.TabIndex = 78;
            this.liquidar.Text = "CARGAR NUEVA TARIFA";
            this.liquidar.UseVisualStyleBackColor = false;
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.Honeydew;
            this.tipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(356, 148);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(142, 27);
            this.tipo.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 76;
            this.label7.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 75;
            this.label5.Text = "Monto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 74;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Chofer";
            // 
            // nuevo_adelanto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.choferes);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.liquidar);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nuevo_adelanto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Adelanto";
            this.Load += new System.EventHandler(this.nuevo_adelanto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox choferes;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Button liquidar;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}