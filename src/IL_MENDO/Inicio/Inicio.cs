using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IL_MENDO.Properties;
using IL_MENDO.ABM_Chofer;
using IL_MENDO.ABM_Camion;
using IL_MENDO.Cargar_Viaje;
using IL_MENDO.ABM_Cliente;
using IL_MENDO.ABM_Tarifas;

namespace IL_MENDO
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void abm_chofer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new chofer();
            frm.ShowDialog();
            frm = (chofer)this.ActiveMdiChild;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new camion();
            frm.ShowDialog();
            frm = (camion)this.ActiveMdiChild;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void nuevo_viaje_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new cargaDatos();
            frm.ShowDialog();
            frm = (cargaDatos)this.ActiveMdiChild;
        }

        private void abm_cliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new cliente();
            frm.ShowDialog();
            frm = (cliente)this.ActiveMdiChild;

        }

        private void abm_estacion_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form frm = new tarifas();
            frm.ShowDialog();
            frm = (tarifas)this.ActiveMdiChild;
        }
    }
}


//TARIFAS REPARTOS CON , ? 
//REMITO TIENE SOLO NUMEROS O - ? 