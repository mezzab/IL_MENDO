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

namespace IL_MENDO.ABM_Chofer
{
    public partial class modificar_chofer : Form
    {
        public static string IDC;
        public static string NOMBRE;
        public static string APELLIDO;
        public static string CAMION;

        public modificar_chofer()
        {
            InitializeComponent();
        }

        private void modificar_chofer_Load(object sender, EventArgs e)
        {
            
            LlenarComboCamiones();
            camionesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            LlenarComboChoferes();
            choferes.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void avisarBien(string quePaso)
        {
            MessageBox.Show(quePaso, "SE INFORMA QUE:", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void avisar(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void LlenarComboCamiones()
        {
            SqlConnection conexion1 = new SqlConnection();
            conexion1.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CAMI_APODO FROM BD.CAMIONES", conexion1);
            da.Fill(ds1, "BD.CAMIONES");

            camionesCombo.DataSource = ds1.Tables[0].DefaultView;
            camionesCombo.ValueMember = "CAMI_APODO";
            camionesCombo.SelectedItem = null;
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
            Form frm = new chofer();
            frm.ShowDialog();
            frm = (chofer)this.ActiveMdiChild;
        }

        private void choferes_SelectedIndexChanged(object sender, EventArgs e)
        {
             string aux = choferes.Text;

             if (aux == "System.Data.DataRowView")
             {
                // MessageBox.Show("no hacer nada");
             }
             if (aux == "")
             {
                 limpiarCampos();
             }
             else if (aux != "System.Data.DataRowView")
             {
                 buscarDatos(aux);
                 cargarDatos();
                                 
             }
            
        }

        private void limpiarCampos()
        {
            camionesCombo.SelectedIndex = -1;
            apellido.Text = "";
            nombre.Text = "";
        }

       

        private void buscarDatos(string apodo)
        {
            if (choferes.Text != "")
            {

                NOMBRE = apodo;

                string sql = "SELECT CHOF_ID FROM BD.CHOFERES " +
                            "WHERE CHOF_NOMBRE ='" + apodo + "'";
                Query qry = new Query(sql);
                IDC = qry.ObtenerUnicoCampo().ToString();

                string sql1 = "SELECT CHOF_APELLIDO FROM BD.CHOFERES " +
                           "WHERE CHOF_ID =" + IDC;
                Query qry1 = new Query(sql1);
                APELLIDO = qry1.ObtenerUnicoCampo().ToString();

                string sql2 = "SELECT CHOF_CAMION_ID FROM BD.CHOFERES " +
                           "WHERE CHOF_ID =" + IDC;
                Query qry2 = new Query(sql2);
                string id_camion = qry2.ObtenerUnicoCampo().ToString();

                string sql3 = "SELECT CAMI_APODO FROM BD.CAMIONES " +
                           "WHERE CAMI_ID =" + id_camion;
                Query qry3 = new Query(sql3);
                CAMION = qry3.ObtenerUnicoCampo().ToString();
            }
        }

        private void cargarDatos()
        {
            nombre.Text = NOMBRE;
            apellido.Text = APELLIDO;
            camionesCombo.Text = CAMION;
        }

        private void Nuevo_Camion_Click(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void actualizarDatos()
        {
            bool seCambioAlgo = false;

            if (NOMBRE != nombre.Text)
            {
                string qry = "update BD.CHOFERES " +
                          " set CHOF_NOMBRE = '" + nombre.Text + "'" +
                          " where CHOF_ID = " + IDC;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (CAMION != camionesCombo.Text)
            {
                string qry = "update BD.CHOFERES " +
                          " set CHOF_CAMION_ID = (SELECT CAMI_ID FROM BD.CAMIONES where CAMI_APODO = '" +camionesCombo.Text + "')" +
                          " where CHOF_ID = " + IDC;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (APELLIDO != apellido.Text)
            {
                string qry = "update BD.CHOFERES " +
                          " set CHOF_APELLIDO = '" + apellido.Text + "'" +
                          " where CHOF_ID = " + IDC;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (seCambioAlgo)
            {
                LlenarComboChoferes();
                string cambio = "Se han guardado los nuevos datos del chofer.";
                avisarBien(cambio);
            }
        }
    }
}
