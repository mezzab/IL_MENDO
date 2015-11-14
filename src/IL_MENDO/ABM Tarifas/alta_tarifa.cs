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
    public partial class alta_tarifa : Form
    {
        public alta_tarifa()
        {
            InitializeComponent();
        }

        private void alta_tarifa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form frm = new tarifas();
            frm.ShowDialog();
            frm = (tarifas)this.ActiveMdiChild;
        }
    }
}
