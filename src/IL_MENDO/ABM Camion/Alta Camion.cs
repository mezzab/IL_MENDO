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

namespace IL_MENDO.ABM_Camion
{
    public partial class Alta_Camion : Form
    {
        public Alta_Camion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void abm_chofer_Click(object sender, EventArgs e)
        {
        

        }

        private bool elApodoYaEsta()
        {
            string sql = "SELECT CAMI_APODO FROM BD.CAMIONES" +
                          " WHERE CAMI_APODO = '" + apodo.Text + "'";
            Query qry = new Query(sql);
            object camion = qry.ObtenerUnicoCampo();


            return camion != null;
        }

        private void avisarBien(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void avisar(string quePaso)
        {
            MessageBox.Show(quePaso, "AVISO! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Alta_Camion_Load(object sender, EventArgs e)
        {

        }

        private void año_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void modelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void apodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool controlarQueEsteTodoCompletado()
        {
            bool estanTodos = false;

            if (apodo.Text != "" &&
            marca.Text != "" &&
            año.Text != "" &&
            modelo.Text != "")
            {
                estanTodos = true;
            }

            return estanTodos;
        }

        private void Nuevo_Camion_Click(object sender, EventArgs e)
        {
            if (controlarQueEsteTodoCompletado())
            {

                if (elApodoYaEsta() == true)
                {
                    avisar("El apodo ya esta, ingresa uno nuevo!");

                }
                if (elApodoYaEsta() == false)
                {
                    string sql = " INSERT INTO [BD].[CAMIONES]" +
                                " ([CAMI_APODO]" +
                                " ,[CAMI_MARCA]" +
                                " ,[CAMI_MODELO]" +
                                " ,[CAMI_AÑOS]" +
                                " ,[CAMI_LITROS_DISPONIBLES])" +
                                " VALUES" +
                                " ('" + apodo.Text + "'" +
                                " ,'" + marca.Text + "'" +
                                " ,'" + modelo.Text + "'" +
                                " ,'" + año.Text + "' ,0 ) ";

                    Query qry = new Query(sql);
                    qry.pComando = sql;
                    qry.Ejecutar();

                    avisarBien("Se cargo el nuevo camion correctamente.");

                    this.Visible = false;
                    Form frm = new Inicio();
                    frm.ShowDialog();
                    frm = (Inicio)this.ActiveMdiChild;


                }
            }
            if (controlarQueEsteTodoCompletado() == false)
            {
                avisar("Debe completar todos los datos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new camion();
            frm.ShowDialog();
            frm = (camion)this.ActiveMdiChild;
        }

        private void año_TextChanged_1(object sender, EventArgs e)
        {
            año.Text = Regex.Replace(año.Text, @"[^\d]", "");
        }
    }
}
