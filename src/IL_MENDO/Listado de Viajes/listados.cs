using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IL_MENDO.Properties;
using System.Globalization;
using System.Text.RegularExpressions;
using IL_MENDO.Listado_de_Viajes;

namespace IL_MENDO.Listados
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
           // fecha.Format = DateTimePickerFormat.Custom;
           // fecha.CustomFormat = "yyyy-dd-MM";
            
            LlenarComboChoferes();            
            LlenarComboClientes();
            choferes.DropDownStyle = ComboBoxStyle.DropDownList;
            clientes.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void avisarBien(string quePaso)
        {
            MessageBox.Show(quePaso, "SE INFORMA QUE:", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void avisar(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void LlenarComboClientes()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CLIE_NOMBRE FROM BD.CLIENTES", conexion);
            da.Fill(ds1, "BD.CLIENTES");

            clientes.DataSource = ds1.Tables[0].DefaultView;
            clientes.ValueMember = "CLIE_NOMBRE";
            clientes.SelectedItem = null;
        }

        public void LlenarComboChoferes()
        {
            SqlConnection conexion1 = new SqlConnection();
            conexion1.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CHOF_NOMBRE FROM BD.CHOFERES", conexion1);
            da.Fill(ds1, "BD.CHOFERES");

            choferes.DataSource = ds1.Tables[0].DefaultView;
            choferes.ValueMember = "CHOF_NOMBRE";
            choferes.SelectedItem = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            viajes frm = new viajes();
            frm.ShowDialog();
            frm = (viajes)this.ActiveMdiChild;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
