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

namespace IL_MENDO.Nuevo_Gasto
{
    public partial class nuevo_gasto : Form
    {
        public nuevo_gasto()
        {
            InitializeComponent();
        }

        private void nuevo_gasto_Load(object sender, EventArgs e)
        {
            LlenarComboCamiones();
            camiones.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LlenarComboCamiones()
        {
            SqlConnection conexion1 = new SqlConnection();
            conexion1.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CAMI_APODO FROM BD.CAMIONES", conexion1);
            da.Fill(ds1, "BD.CAMIONES");

            camiones.DataSource = ds1.Tables[0].DefaultView;
            camiones.ValueMember = "CAMI_APODO";
            camiones.SelectedItem = null;
        }

        private void costo_TextChanged(object sender, EventArgs e)
        {
            costo.Text = Regex.Replace(costo.Text, @"[^\d]", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void camiones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void liquidar_Click(object sender, EventArgs e)
        {

        }

        private void tipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
