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

namespace IL_MENDO.Nuevo_Adelanto
{
    public partial class nuevo_adelanto : Form
    {
        public nuevo_adelanto()
        {
            InitializeComponent();
        }

        private void nuevo_adelanto_Load(object sender, EventArgs e)
        {
            LlenarComboChoferes();
         
            choferes.DropDownStyle = ComboBoxStyle.DropDownList;
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
    }
}
