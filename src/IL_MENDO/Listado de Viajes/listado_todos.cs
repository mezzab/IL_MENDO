using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IL_MENDO.Listado_de_Viajes
{
    public partial class Listado_Todos : Form
    {
        public Listado_Todos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string qry = "SELECT CL.CLIE_NOMBRE CLIENTE, C1.CIUD_DETALLE ORIGEN, C2.CIUD_DETALLE DESTINO, CH.CHOF_NOMBRE CHOFER, R.REMI_CODIGO REMITO, E.ESTA_DESCRIPCION ESTADO, V.VIAJ_FECHA FECHA, V.VIAJ_KILOMETROS KMS, V.VIAJ_TONELADAS TONELADAS, V.VIAJ_IMPORTE IMPORTE" +
                           " FROM BD.VIAJES V, BD.CLIENTES CL, BD.CHOFERES CH,BD.REMITOS R, BD.ESTADO_VIAJE E, BD.CIUDADES C1, BD.CIUDADES C2" +
                           " WHERE V.VIAJ_CHOFER_ID = CH.CHOF_ID AND V.VIAJ_CLIENTE_ID = CL.CLIE_ID AND V.VIAJ_CARGA_ID = C1.CIUD_ID AND V.VIAJ_DESCARGA_ID = C2.CIUD_ID " +
                           " AND V.VIAJ_ESTADO_ID = E.ESTA_ID AND V.VIAJ_REMITO_ID = R.REMI_ID" + 
                           " ORDER BY V.VIAJ_ID DESC";


            viajes.DataSource = new Query(qry).ObtenerDataTable();
            viajes.ReadOnly = true;
            viajes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            viajes.AllowUserToResizeColumns = true;
            //viajes.DefaultCellStyle.Font = Calibri;
            viajes.RowsDefaultCellStyle.BackColor = Color.White  ;
            viajes.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
  
            // pasajes.Columns[""].Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            viajes frm = new viajes();
            frm.ShowDialog();
            frm = (viajes)this.ActiveMdiChild;
        }
    }
}
