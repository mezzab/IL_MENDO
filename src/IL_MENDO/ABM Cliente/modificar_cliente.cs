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

namespace IL_MENDO.ABM_Cliente
{
    public partial class modificar_cliente : Form
    {
        public static string NOMBRE;
        public static string DESCRIPCION;
        public static string IMPORTEMINIMO;
        public static string TARIFAREPARTOS;
        public static string TARIFALDNOMBRE;
        public static string IDCLIENTE;

        public modificar_cliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void moficar_cliente_Load(object sender, EventArgs e)
        {
            LlenarComboClientes();
            clientes.DropDownStyle = ComboBoxStyle.DropDownList;
            LlenarComboTarifas();
            tarifas.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void avisarBien(string quePaso)
        {
            MessageBox.Show(quePaso, "SE INFORMA QUE:", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void avisar(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void LlenarComboTarifas()
        {
            SqlConnection conexion0 = new SqlConnection();
            conexion0.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TARI_NOMBRE FROM BD.TARIFAS", conexion0);
            da.Fill(ds1, "BD.TARIFAS");

            tarifas.DataSource = ds1.Tables[0].DefaultView;
            tarifas.ValueMember = "TARI_NOMBRE";
            tarifas.SelectedItem = null;
        }


        public void LlenarComboClientes()
        {
            SqlConnection conexion1 = new SqlConnection();
            conexion1.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT CLIE_NOMBRE FROM BD.CLIENTES", conexion1);
            da.Fill(ds1, "BD.CLIENTES");

            clientes.DataSource = ds1.Tables[0].DefaultView;
            clientes.ValueMember = "CLIE_NOMBRE";
            clientes.SelectedItem = null;
        }

        private void guardarNuevosDatos_Click(object sender, EventArgs e)
        {
            actualizarDatos();
        }
        
        private void actualizarDatos()
        {//TODO:
            bool seCambioAlgo = false;

            if (NOMBRE != nombre.Text)
            {
                string qry = "update BD.CLIENTES " +
                          " set CLIE_NOMBRE = '" + nombre.Text + "'" +
                          " where CLIE_ID = " + IDCLIENTE;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (TARIFALDNOMBRE != tarifas.Text)
            {

                 string qry = "update BD.CLIENTES " +
                          " set CLIE_TARIFA_LARGA_DIST_ID = (SELECT TARI_ID FROM BD.TARIFAS where TARI_NOMBRE = '" + tarifas.Text + "')" +
                          " where CLIE_ID = " + IDCLIENTE;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (DESCRIPCION != descripcion.Text)
            {
                string qry = "update BD.CLIENTES " +
                          " set CLIE_DESCRIPCION = '" + descripcion.Text + "'" +
                          " where CLIE_ID = " + IDCLIENTE;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (TARIFAREPARTOS != tarifaRepartos.Text)
            {

                string aux0 = tarifaRepartos.Text;
                string aux1 = aux0.ToString().Replace(",", ".");



                string qry = "update BD.CLIENTES " +
                          " set CLIE_TARIFA = '" + aux1 + "'" +
                          " where CLIE_ID = " + IDCLIENTE;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (IMPORTEMINIMO != importeMinimo.Text)
            {

                string aux2 = importeMinimo.Text;
                string aux3 = aux2.ToString().Replace(",", ".");

                string qry = "update BD.CLIENTES " +
                          " set CLIE_IMPORTE_MIN = '" + aux3 + "'" +
                          " where CLIE_ID = " + IDCLIENTE;

                new Query(qry).Ejecutar();

                seCambioAlgo = true;
            }
            if (seCambioAlgo)
            {
                string cambio = "Se guardaron los nuevos datos del cliente con exito.";
                LlenarComboClientes();
                avisarBien(cambio);
            }
        }
        
        private void clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aux = clientes.Text;

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
            tarifas.SelectedIndex = -1;
            nombre.Text = "";
            descripcion .Text = "";
            importeMinimo.Text = "";
            tarifaRepartos.Text = "";
        }



        private void buscarDatos(string apodo)
        {
            if (clientes.Text != "")
            {

                NOMBRE = apodo;

                string sql = "SELECT CLIE_ID FROM BD.CLIENTES " +
                            "WHERE CLIE_NOMBRE ='" + apodo + "'";
                Query qry = new Query(sql);
                IDCLIENTE = qry.ObtenerUnicoCampo().ToString();

                string sql1 = "SELECT CLIE_NOMBRE FROM BD.CLIENTES " +
                           "WHERE CLIE_ID =" + IDCLIENTE;
                Query qry1 = new Query(sql1);
                NOMBRE = qry1.ObtenerUnicoCampo().ToString();

                string sql0 = "SELECT CLIE_DESCRIPCION FROM BD.CLIENTES " +
                          "WHERE CLIE_ID =" + IDCLIENTE;
                Query qry0 = new Query(sql0);
                DESCRIPCION = qry0.ObtenerUnicoCampo().ToString();

                string sql7 = "SELECT CLIE_IMPORTE_MIN FROM BD.CLIENTES " +
                         "WHERE CLIE_ID =" + IDCLIENTE;
                Query qry7 = new Query(sql7);
                IMPORTEMINIMO = qry7.ObtenerUnicoCampo().ToString();

                string sql5 = "SELECT CLIE_TARIFA FROM BD.CLIENTES " +
                                 "WHERE CLIE_ID =" + IDCLIENTE;
                Query qry5 = new Query(sql5);
                TARIFAREPARTOS = qry5.ObtenerUnicoCampo().ToString();

                string sql2 = "SELECT CLIE_TARIFA_LARGA_DIST_ID FROM BD.CLIENTES " +
                                "WHERE CLIE_ID =" + IDCLIENTE;
                Query qry2 = new Query(sql2);
                string id_tarifa_larga_distancia = qry2.ObtenerUnicoCampo().ToString();

                string sql3 = "SELECT TARI_NOMBRE FROM BD.TARIFAS " +
                                  "WHERE TARI_ID =" + id_tarifa_larga_distancia;
                Query qry3 = new Query(sql3);
                TARIFALDNOMBRE = qry3.ObtenerUnicoCampo().ToString();
            }
        }

        private void cargarDatos()
        {
            tarifas.Text = TARIFALDNOMBRE;
            nombre.Text = NOMBRE;
            descripcion.Text = DESCRIPCION;
            importeMinimo.Text = IMPORTEMINIMO;
            tarifaRepartos.Text = TARIFAREPARTOS;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            Form frm = new cliente();
            frm.ShowDialog();
            frm = (cliente)this.ActiveMdiChild;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tarifaRepartos_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
