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
    public partial class Alta_Chofer : Form
    {
        public Alta_Chofer()
        {
            InitializeComponent();
        }

        private void Alta_Chofer_Load(object sender, EventArgs e)
        {
            LlenarComboCamiones();
            camionesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm = new chofer();
            frm.ShowDialog();
            frm = (chofer)this.ActiveMdiChild;
        }

        private bool controlarQueEsteTodoCompletado()
        {
            bool estanTodos = false;

            if (nombre.Text != "" &&
            apellido.Text != "" &&
            camionesCombo.Text != "")

            {
                estanTodos = true;
            }

            return estanTodos;
        }

        private void Nuevo_Camion_Click(object sender, EventArgs e)
        {
            if (controlarQueEsteTodoCompletado())
            {

                if (elChoferYaEsta() == true)
                {
                    avisar("El apodo ya esta, ingresa uno nuevo!");

                }
                if (elChoferYaEsta() == false)
                {
                    string sql = " INSERT INTO [BD].[CHOFERES]" +
                                " ([CHOF_NOMBRE]" +
                                " ,[CHOF_APELLIDO]" +
                                " ,[CHOF_CAMION_ID])" +
                                " VALUES" +
                                " ('" + nombre.Text + "'" +
                                " ,'" + apellido.Text + "'" +
                                " ,(SELECT CAMI_ID FROM BD.CAMIONES WHERE CAMI_APODO = '" + camionesCombo.Text + "' ))";

                    Query qry = new Query(sql);
                    qry.pComando = sql;
                    qry.Ejecutar();

                    avisarBien("Se cargo el nuevo chofer correctamente.");

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

        private bool elChoferYaEsta()
        {
            string sql = "SELECT * FROM BD.CHOFERES" +
                          " WHERE CHOF_NOMBRE = '" + nombre.Text + "' AND CHOF_APELLIDO = '" + apellido.Text + "'" ;
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

        private void camionesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
