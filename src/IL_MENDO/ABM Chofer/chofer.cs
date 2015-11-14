using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IL_MENDO.ABM_Chofer
{
    public partial class chofer : Form
    {
        public chofer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new Inicio();
            frm.ShowDialog();
            frm = (Inicio)this.ActiveMdiChild;
        }

        private void abm_chofer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new Alta_Chofer();
            frm.ShowDialog();
            frm = (Alta_Chofer)this.ActiveMdiChild;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avisarBien("No esta implementada la baja todavia");
       
        }

        private void avisarBien(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void chofer_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new modificar_chofer();
            frm.ShowDialog();
            frm = (modificar_chofer)this.ActiveMdiChild;
        }
    }
}
