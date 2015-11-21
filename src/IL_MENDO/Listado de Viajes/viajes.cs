using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IL_MENDO.Listados;

namespace IL_MENDO.Listado_de_Viajes
{
    public partial class viajes : Form
    {
        public viajes()
        {
            InitializeComponent();
        }

        private void viajes_Load(object sender, EventArgs e)
        {

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
            Form frm = new Listado_Todos();
            frm.ShowDialog();
            frm = (Listado_Todos)this.ActiveMdiChild;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form frm = new Listado();
            frm.ShowDialog();
            frm = (Listado)this.ActiveMdiChild;
        }
    }
}
