using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IL_MENDO.ABM_Cliente
{
    public partial class cliente : Form
    {
        public cliente()
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
            Form frm = new alta_cliente();
            frm.ShowDialog();
            frm = (alta_cliente)this.ActiveMdiChild;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No esta implementada la baja todavia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new modificar_cliente();
            frm.ShowDialog();
            frm = (modificar_cliente)this.ActiveMdiChild;
        }
    }
}
