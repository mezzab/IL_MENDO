namespace IL_MENDO.ABM_Camion
{
    partial class Alta_Camion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_Camion));
            this.button2 = new System.Windows.Forms.Button();
            this.año = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nuevo_Camion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(12, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "ATRAS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // año
            // 
            this.año.BackColor = System.Drawing.Color.Honeydew;
            this.año.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.año.Location = new System.Drawing.Point(340, 317);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(140, 27);
            this.año.TabIndex = 7;
            this.año.TextChanged += new System.EventHandler(this.año_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Año";
            // 
            // modelo
            // 
            this.modelo.BackColor = System.Drawing.Color.Honeydew;
            this.modelo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo.Location = new System.Drawing.Point(340, 246);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(140, 27);
            this.modelo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // marca
            // 
            this.marca.BackColor = System.Drawing.Color.Honeydew;
            this.marca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca.Location = new System.Drawing.Point(340, 178);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(140, 27);
            this.marca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // apodo
            // 
            this.apodo.BackColor = System.Drawing.Color.Honeydew;
            this.apodo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apodo.Location = new System.Drawing.Point(340, 101);
            this.apodo.Name = "apodo";
            this.apodo.Size = new System.Drawing.Size(140, 27);
            this.apodo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apodo";
            // 
            // Nuevo_Camion
            // 
            this.Nuevo_Camion.BackColor = System.Drawing.SystemColors.Menu;
            this.Nuevo_Camion.Location = new System.Drawing.Point(340, 386);
            this.Nuevo_Camion.Name = "Nuevo_Camion";
            this.Nuevo_Camion.Size = new System.Drawing.Size(140, 52);
            this.Nuevo_Camion.TabIndex = 8;
            this.Nuevo_Camion.Text = "CARGAR NUEVO CAMION";
            this.Nuevo_Camion.UseVisualStyleBackColor = false;
            this.Nuevo_Camion.Click += new System.EventHandler(this.Nuevo_Camion_Click);
            // 
            // Alta_Camion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(816, 516);
            this.Controls.Add(this.año);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nuevo_Camion);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alta_Camion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Camion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox año;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nuevo_Camion;
    }
}