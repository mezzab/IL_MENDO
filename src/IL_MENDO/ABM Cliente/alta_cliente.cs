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
    public partial class alta_cliente : Form
    {
        public alta_cliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form frm = new cliente();
            frm.ShowDialog();
            frm = (cliente)this.ActiveMdiChild;
        }

        private bool elNombreYaEsta()
        {
            string sql = "SELECT CLIE_NOMBRE FROM BD.CLIENTES" +
                          " WHERE CLIE_NOMBRE = '" + nombre.Text + "'";
            Query qry = new Query(sql);
            object camion = qry.ObtenerUnicoCampo();

            return camion != null;
        }

        private void liquidar_Click(object sender, EventArgs e)
        {
            if (controlarQueEsteTodoCompletado())
            {
                if (elNombreYaEsta() == true)
                {
                    avisar("El nombre del cliente ya esta, ingresa uno nuevo!");

                }
                if (elNombreYaEsta() == false)
                {
                    string sql = " INSERT INTO [BD].[CLIENTES]" +
                                " ([CLIE_DESCRIPCION]" +
                                " ,[CLIE_NOMBRE]" +
                                " ,[CLIE_TARIFA]" +
                                " ,[CLIE_TARIFA_LARGA_DIST_ID]" +
                                " ,[CLIE_IMPORTE_MIN])" +
                                " VALUES" +
                                " ('" + descripcion.Text + "'" +
                                 " ,'" + nombre.Text + "'" +
                                " ,'" + tarifaRepartos.Text + "'" +
                                " ,(SELECT TARI_ID FROM BD.TARIFAS WHERE TARI_NOMBRE = '" + tarifas.Text + "' )" +
                                " ,'" + importeMinimo.Text + "')";

                    Query qry = new Query(sql);
                    qry.pComando = sql;
                    qry.Ejecutar();

                    avisarBien("Se cargo el nuevo cliente correctamente");

                    this.Visible = false;
                    Form frm = new Inicio();
                    frm.ShowDialog();
                    frm = (Inicio)this.ActiveMdiChild;
                }
                if (controlarQueEsteTodoCompletado() == false)
                {
                    avisar("Debe completar todos los datos.");
                }
            }

        }


        private bool controlarQueEsteTodoCompletado()
        {
            bool estanTodos = false;

            if (descripcion.Text != "" &&
            tarifaRepartos.Text != "" &&
            importeMinimo.Text != "" &&
            tarifas.Text != "")
            {
                estanTodos = true;
            }

            return estanTodos;
        }

        private void alta_cliente_Load(object sender, EventArgs e)
        {
            LlenarComboTarifas();
            tarifas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LlenarComboTarifas()
        {
            SqlConnection conexion1 = new SqlConnection();
            conexion1.ConnectionString = Settings.Default.CadenaDeConexion;

            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TARI_NOMBRE FROM BD.TARIFAS", conexion1);
            da.Fill(ds1, "BD.TARIFAS");

            tarifas.DataSource = ds1.Tables[0].DefaultView;
            tarifas.ValueMember = "TARI_NOMBRE";
            tarifas.SelectedItem = null;
        }

        private void avisarBien(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void avisar(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void importeMinimo_TextChanged(object sender, EventArgs e)
        {
            //importeMinimo.Text = Regex.Replace(importeMinimo.Text, @"[^\d]", "");
        }

        private void tarifaRepartos_TextChanged(object sender, EventArgs e)
        {
           // tarifaRepartos.Text = Regex.Replace(tarifaRepartos.Text, @"[^\d]",String.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    

    }

}


//TODO: que se ingresen , ademas de numeros
//TODO: orden de los textbox ordenar para que ande con tab