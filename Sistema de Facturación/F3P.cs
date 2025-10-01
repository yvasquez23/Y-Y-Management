using System;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_Facturación
{
    public partial class F3P : Form
    {
        

        public F3P()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            {
                Conexion.Conectar();
                string consulta = "Select * from ventas where num_fac =@parametro";
                SqlCommand comando = new SqlCommand(consulta, Conexion.Conectar());
                comando.Parameters.AddWithValue("@parametro", numero.Text);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                ReportDocument reporte = CRV3P.ReportSource as ReportDocument;
                reporte.SetDataSource(dt);
                CRV3P.Refresh();

            }
        }
    }
}

