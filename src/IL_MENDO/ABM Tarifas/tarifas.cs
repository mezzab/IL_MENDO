using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IL_MENDO.ABM_Tarifas
{
    public partial class tarifas : Form
    {
        public tarifas()
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
            Form frm = new alta_tarifa();
            frm.ShowDialog();
            frm = (alta_tarifa)this.ActiveMdiChild;

        }
    }
}
