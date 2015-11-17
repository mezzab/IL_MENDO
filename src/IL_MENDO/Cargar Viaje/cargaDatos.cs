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
            kilometros.Text = Regex.Replace(kilometros.Text, @"[^\d]", "");
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
            fecha.Format = DateTimePickerFormat.Custom;
            fecha.CustomFormat = "yyyy-dd-MM";
            
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

                string ax = kilometros.Text;
                decimal kilo = Convert.ToDecimal(ax);

                string a = toneladas.Text;
                string au = a.ToString().Replace(".", ",");

                decimal tone = Convert.ToDecimal(au);

                string kil = kilo.ToString().Replace(",", ".");
                string ton = tone.ToString().Replace(",", ".");

                if (tipo.Text == "Reparto")
                {
                    
                    string sql = "SELECT CLIE_TARIFA FROM BD.CLIENTES " +
                            "WHERE CLIE_ID ='" + CLIENTE_ID + "'";
                    Query qry = new Query(sql);
                    decimal TARIFA = Convert.ToDecimal(qry.ObtenerUnicoCampo().ToString());

                    string sql1 = "SELECT CLIE_IMPORTE_MIN FROM BD.CLIENTES " +
                           "WHERE CLIE_ID ='" + CLIENTE_ID + "'";
                    Query qry1 = new Query(sql1);
                    decimal IMPORTE_MIN = Convert.ToDecimal(qry1.ObtenerUnicoCampo().ToString());

                    decimal total = kilo * TARIFA;
                  
                    string aux = fecha.Text + " 00:00:00.000";

                    if (total > IMPORTE_MIN)
                    {
                        string tot = total.ToString().Replace(",", ".");

                        string sqlt = "INSERT INTO [BD].[VIAJES] " +
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
                                   " , " + CHOFER_ID +
                                   " , " + REMITO_ID +
                                   " , " + 1 +
                                   " , " + kil +
                                   ", '" + aux + "'" +
                                   " , " + ton+
                                   " , " +tot +
                                   " , '" + TIPO + "')";

                        Query qryt = new Query(sqlt);
                        qryt.pComando = sqlt;
                        qryt.Ejecutar();

                        avisarBien("Se cargo correctamente el viaje.");
                    
                    }
                    if (total < IMPORTE_MIN)
                    {
                        string IMP = IMPORTE_MIN.ToString().Replace(",", ".");
                        
                        string sqlt = "INSERT INTO [BD].[VIAJES] " +
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
                                   " , " + CHOFER_ID +
                                   " , " + REMITO_ID +
                                   " , " + 1 +
                                   " , " + kil+
                                   ", '" + aux + "'" +
                                   " , " + ton +
                                   " , " + IMP  +
                                   " , '" + TIPO + "')";

                        Query qryt = new Query(sqlt);
                        qryt.pComando = sqlt;
                        qryt.Ejecutar();

                        avisarBien("Se cargo correctamente el viaje.");

                    }
                    

                }
                if (tipo.Text == "Larga distancia")
                {

                    string aux = fecha.Text + " 00:00:00.000";

                    string kilometers = kilo.ToString();

                    string sql = "SELECT FILA_PRECIO FROM BD.TARIFAS" +
                                " JOIN BD.FILA_TARIFA ON FILA_TARI_ID=TARI_ID" +
                                " WHERE TARI_ID=(SELECT CLIE_TARIFA_LARGA_DIST_ID FROM BD.CLIENTES" +
                                " WHERE CLIE_ID ='" + CLIENTE_ID + "')" +
                                " AND FILA_KILOMETRO ='"+ kilometers + "'";
                    Query qry = new Query(sql);
                    decimal TARIFA_LARGA_DISTANCIA = Convert.ToDecimal(qry.ObtenerUnicoCampo().ToString());


                    decimal monto = TARIFA_LARGA_DISTANCIA * tone;


                    string TOT = monto.ToString().Replace(",", ".");

                    string sqlt = "INSERT INTO [BD].[VIAJES] " +
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
                               " , " + CHOFER_ID +
                               " , " + REMITO_ID +
                               " , " + 1 +
                               " , " + kil +
                               ", '" + aux + "'" +
                               " , " + ton +
                               " , " + TOT +
                               " , '" + TIPO + "')";

                    Query qryt = new Query(sqlt);
                    qryt.pComando = sqlt;
                    qryt.Ejecutar();

                    avisarBien("Se cargo correctamente el viaje.");

                }

            }

        }

        public void ConvertStringDecimal(string stringVal)
        {
            decimal decimalVal = 0;

            try
            {
                decimalVal = System.Convert.ToDecimal(stringVal);
                System.Console.WriteLine(
                    "The string as a decimal is {0}.", decimalVal);
            }
            catch (System.OverflowException)
            {
                System.Console.WriteLine(
                    "The conversion from string to decimal overflowed.");
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine(
                    "The string is not formatted as a decimal.");
            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine(
                    "The string is null.");
            }

            // Decimal to string conversion will not overflow.
            stringVal = System.Convert.ToString(decimalVal);
            System.Console.WriteLine(
                "The decimal as a string is {0}.", stringVal);
        }	

        private void buscarIDs()
        {
            string sql = "SELECT CLIE_ID FROM BD.CLIENTES " +
                            "WHERE CLIE_NOMBRE ='" + clientes.Text + "'";
            Query qry = new Query(sql);
            CLIENTE_ID = qry.ObtenerUnicoCampo().ToString();

            string sql1 = "SELECT CHOF_ID FROM BD.CHOFERES " +
                            "WHERE CHOF_NOMBRE ='" + choferes.Text + "'";
            Query qry1 = new Query(sql1);
            CHOFER_ID = qry1.ObtenerUnicoCampo().ToString();

            string remi = "INSERT INTO [BD].[REMITOS] " +
                            "([REMI_CODIGO]) " +
                            "VALUES " +
                            "('"+ remito.Text +"') ";
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

        private void tone_ValueChanged(object sender, EventArgs e)
        {

        }

 
    }
}


//TODO: Que busque destinos mientras se a tecleando!