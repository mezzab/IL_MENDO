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


namespace IL_MENDO.Cargar_Viaje
{
    public partial class cargaDatos : Form
    {

           public static string CLIENTE_ID;
           public static string CHOFER_ID;
           public static string REMITO_ID;
           public static string TIPO;

        public cargaDatos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void camionesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new Inicio();
            frm.ShowDialog();
            frm = (Inicio)this.ActiveMdiChild;
        }

        private void reparto_Load(object sender, EventArgs e)
        {
            LlenarComboChoferes();            
            LlenarComboClientes();
            choferes.DropDownStyle = ComboBoxStyle.DropDownList;
            clientes.DropDownStyle = ComboBoxStyle.DropDownList;

            tipo.Items.Add("Reparto");
            tipo.Items.Add("Larga distancia");
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.SelectedItem = null;

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


        private void toneladas_TextChanged(object sender, EventArgs e)
        {

        }

        private void liquidar_Click(object sender, EventArgs e)
        {
            if (controlarQueEsteTodoCompletado()==false)
            {

            }
            if (controlarQueEsteTodoCompletado()) //TODO:
            {
                buscarIDs();

                string sql = "INSERT INTO [BD].[VIAJES] " + 
                                   "([VIAJ_CLIENTE_ID] " + 
                                   ",[VIAJ_CHOFER_ID] " + 
                                   ",[VIAJ_REMITO_ID] " + 
                                   ",[VIAJ_ESTADO_ID] " + 
                                   ",[VIAJ_KILOMETROS] " + 
                                   ",[VIAJ_FECHA] " + 
                                   ",[VIAJ_TONELADAS] " + 
                                   ",[VIAJ_IMPORTE] " + 
                                   ",[VIAJ_TIPO]) " + 
                             "VALUES " + 
                                   "( " + CLIENTE_ID + 
                                   ", " + CHOFER_ID +
                                   ", " + REMITO_ID +
                                   ", " + 1 + 
                                   ", " + kilometros.Text +
                                   ",<VIAJ_FECHA, datetime,> " + 
                                   ", " + toneladas.Text +
                                   ",<VIAJ_IMPORTE, money,> " + 
                                   ","+ TIPO +")";
                Query qry = new Query(sql);
                qry.pComando = sql;
                qry.Ejecutar();

                avisarBien("Se cargo el nuevo cliente correctamente");
            }

        }

        private void buscarIDs()
        {
            string sql = "SELECT CLIE_ID FROM BD.CLIENTES " +
                            "WHERE CLIE_NOMBRE ='" + clientes.Text + "'";
            Query qry = new Query(sql);
            CLIENTE_ID = qry.ObtenerUnicoCampo().ToString();

            string sql1 = "SELECT CLIE_ID FROM BD.CHOFERES " +
                            "WHERE CHOF_NOMBRE ='" + clientes.Text + "'";
            Query qry1 = new Query(sql1);
            CHOFER_ID = qry1.ObtenerUnicoCampo().ToString();

            string remi = "INSERT INTO [BD].[REMITOS] " +
                            "([REMI_CODIGO]) " +
                            "VALUES " +
                            "("+ remito.Text +") ";
            Query qry3 = new Query(remi);
            qry3.pComando = remi;
            qry3.Ejecutar();

            string sql2 = "SELECT REMI_ID FROM BD.REMITOS " +
                "WHERE REMI_CODIGO ='" + remito.Text + "'";
            Query qry2 = new Query(sql2);
            REMITO_ID = qry2.ObtenerUnicoCampo().ToString();

        }

        private bool controlarQueEsteTodoCompletado()
        {
            bool estanTodos = false;

            if (choferes.Text != "" &&
                clientes.Text != "" &&
                carga.Text != "" &&
                descarga.Text != "" &&
                toneladas.Text != "" &&
                tipo.Text != "" &&
                kilometros.Text != "")
            {
                estanTodos = true;
            }

            return estanTodos;
        }

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipo.Text == "Reparto")
            {
                TIPO = "R";
            }
            if (tipo.Text == "Larga distancia")
            {
                TIPO = "L";
            }
        }

    }
}
