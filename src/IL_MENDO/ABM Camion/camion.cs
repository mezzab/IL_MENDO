using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IL_MENDO.ABM_Camion
{
    public partial class camion : Form
    {
        public camion()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            avisarBien("No esta implementada esta funcionalidad.");
        }

        private void camion_Load(object sender, EventArgs e)
        {

        }

        private void avisarBien(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void abm_chofer_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new Alta_Camion();
            frm.ShowDialog();
            frm = (Alta_Camion)this.ActiveMdiChild;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new Inicio();
            frm.ShowDialog();
            frm = (Inicio)this.ActiveMdiChild;
        }
    }
}
