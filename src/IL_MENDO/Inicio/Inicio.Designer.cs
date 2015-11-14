namespace IL_MENDO
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.abm_chofer = new System.Windows.Forms.Button();
            this.abm_camion = new System.Windows.Forms.Button();
            this.abm_estacion = new System.Windows.Forms.Button();
            this.abm_cliente = new System.Windows.Forms.Button();
            this.nuevo_tramo = new System.Windows.Forms.Button();
            this.abm_lugares = new System.Windows.Forms.Button();
            this.nuevo_viaje = new System.Windows.Forms.Button();
            this.liquidar = new System.Windows.Forms.Button();
            this.adelanto_chofer = new System.Windows.Forms.Button();
            this.carga_gasto = new System.Windows.Forms.Button();
            this.carga_gasoil = new System.Windows.Forms.Button();
            this.pago_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abm_chofer
            // 
            resources.ApplyResources(this.abm_chofer, "abm_chofer");
            this.abm_chofer.BackColor = System.Drawing.SystemColors.Menu;
            this.abm_chofer.Name = "abm_chofer";
            this.abm_chofer.UseVisualStyleBackColor = false;
            this.abm_chofer.Click += new System.EventHandler(this.abm_chofer_Click);
            // 
            // abm_camion
            // 
            resources.ApplyResources(this.abm_camion, "abm_camion");
            this.abm_camion.BackColor = System.Drawing.SystemColors.Menu;
            this.abm_camion.Name = "abm_camion";
            this.abm_camion.UseVisualStyleBackColor = false;
            this.abm_camion.Click += new System.EventHandler(this.button1_Click);
            // 
            // abm_estacion
            // 
            resources.ApplyResources(this.abm_estacion, "abm_estacion");
            this.abm_estacion.BackColor = System.Drawing.SystemColors.Menu;
            this.abm_estacion.Name = "abm_estacion";
            this.abm_estacion.UseVisualStyleBackColor = false;
            this.abm_estacion.Click += new System.EventHandler(this.abm_estacion_Click);
            // 
            // abm_cliente
            // 
            resources.ApplyResources(this.abm_cliente, "abm_cliente");
            this.abm_cliente.BackColor = System.Drawing.SystemColors.Menu;
            this.abm_cliente.Name = "abm_cliente";
            this.abm_cliente.UseVisualStyleBackColor = false;
            this.abm_cliente.Click += new System.EventHandler(this.abm_cliente_Click);
            // 
            // nuevo_tramo
            // 
            resources.ApplyResources(this.nuevo_tramo, "nuevo_tramo");
            this.nuevo_tramo.BackColor = System.Drawing.SystemColors.Menu;
            this.nuevo_tramo.Name = "nuevo_tramo";
            this.nuevo_tramo.UseVisualStyleBackColor = false;
            // 
            // abm_lugares
            // 
            resources.ApplyResources(this.abm_lugares, "abm_lugares");
            this.abm_lugares.BackColor = System.Drawing.SystemColors.Menu;
            this.abm_lugares.Name = "abm_lugares";
            this.abm_lugares.UseVisualStyleBackColor = false;
            // 
            // nuevo_viaje
            // 
            resources.ApplyResources(this.nuevo_viaje, "nuevo_viaje");
            this.nuevo_viaje.BackColor = System.Drawing.SystemColors.Menu;
            this.nuevo_viaje.Name = "nuevo_viaje";
            this.nuevo_viaje.UseVisualStyleBackColor = false;
            this.nuevo_viaje.Click += new System.EventHandler(this.nuevo_viaje_Click);
            // 
            // liquidar
            // 
            resources.ApplyResources(this.liquidar, "liquidar");
            this.liquidar.BackColor = System.Drawing.SystemColors.Menu;
            this.liquidar.Name = "liquidar";
            this.liquidar.UseVisualStyleBackColor = false;
            // 
            // adelanto_chofer
            // 
            resources.ApplyResources(this.adelanto_chofer, "adelanto_chofer");
            this.adelanto_chofer.BackColor = System.Drawing.SystemColors.Menu;
            this.adelanto_chofer.Name = "adelanto_chofer";
            this.adelanto_chofer.UseVisualStyleBackColor = false;
            // 
            // carga_gasto
            // 
            resources.ApplyResources(this.carga_gasto, "carga_gasto");
            this.carga_gasto.BackColor = System.Drawing.SystemColors.Menu;
            this.carga_gasto.Name = "carga_gasto";
            this.carga_gasto.UseVisualStyleBackColor = false;
            // 
            // carga_gasoil
            // 
            resources.ApplyResources(this.carga_gasoil, "carga_gasoil");
            this.carga_gasoil.BackColor = System.Drawing.SystemColors.Menu;
            this.carga_gasoil.Name = "carga_gasoil";
            this.carga_gasoil.UseVisualStyleBackColor = false;
            // 
            // pago_cliente
            // 
            resources.ApplyResources(this.pago_cliente, "pago_cliente");
            this.pago_cliente.BackColor = System.Drawing.SystemColors.Menu;
            this.pago_cliente.Name = "pago_cliente";
            this.pago_cliente.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.nuevo_viaje);
            this.Controls.Add(this.liquidar);
            this.Controls.Add(this.adelanto_chofer);
            this.Controls.Add(this.carga_gasto);
            this.Controls.Add(this.carga_gasoil);
            this.Controls.Add(this.pago_cliente);
            this.Controls.Add(this.nuevo_tramo);
            this.Controls.Add(this.abm_lugares);
            this.Controls.Add(this.abm_estacion);
            this.Controls.Add(this.abm_cliente);
            this.Controls.Add(this.abm_camion);
            this.Controls.Add(this.abm_chofer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button abm_chofer;
        private System.Windows.Forms.Button abm_camion;
        private System.Windows.Forms.Button abm_estacion;
        private System.Windows.Forms.Button abm_cliente;
        private System.Windows.Forms.Button nuevo_tramo;
        private System.Windows.Forms.Button abm_lugares;
        private System.Windows.Forms.Button nuevo_viaje;
        private System.Windows.Forms.Button liquidar;
        private System.Windows.Forms.Button adelanto_chofer;
        private System.Windows.Forms.Button carga_gasto;
        private System.Windows.Forms.Button carga_gasoil;
        private System.Windows.Forms.Button pago_cliente;
    }
}

