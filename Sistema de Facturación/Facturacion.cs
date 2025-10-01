using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturación
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void pre_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtotal_Click(object sender, EventArgs e)
        {

        }



        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable eliminar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "Delete Temdetallefactura";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        private void nuevo_Click(object sender, EventArgs e)
        {
            articulo.Enabled = true;
            descripcion.Enabled = true;
            precio.Enabled = true;
            cantidad.Enabled = true;

           
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            
            this.pdf.Text = "0";
            this.pitbis.Text = "0";
            daf.Text = "0";
            itbis.Text = "0";

           
            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(num_fac AS INT)),0)+1 FROM factura", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            numfactura.Text = dt.Rows[0][0].ToString();

            
            tipodefactura.Text = "Efectivo";
            cliente.Text = "1";
            nombre.Text = "GENERICO";
            articulo.Focus();
            fechahora.Enabled = true;
            guardar.Enabled = true;

           
            eliminar_grid();

           
            TDF.DataSource = null;    
            TDF.Rows.Clear();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'factura.Temdetallefactura' Puede moverla o quitarla según sea necesario.
            this.temdetallefacturaTableAdapter.Fill(this.factura.Temdetallefactura);
            articulo.Enabled = false;
            descripcion.Enabled = false;
            precio.Enabled = false;
            cantidad.Enabled = false;
            subtot.Enabled = false;
            guardar.Enabled = false;
            imprimir.Enabled = false;
            daf.Text = "0";
            itbis.Text = "0";
            this.pdf.Text = "0";
            this.pitbis.Text = "0";

            TDF.DataSource = eliminar_grid();


            TDF.RowHeadersVisible = false;

        }

        private void fechahora_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss");
            fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void bus_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.Show();
        }

        private void busc_Click(object sender, EventArgs e)
        {
            Articulo frm = new Articulo();
            frm.Show();
        }

        private void cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsql = "select *from Cliente where cod_cli='" + cliente.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    nombre.Text = leer["nom_cli"].ToString();
                }
                else
                {
                    nombre.Text = "No encontrado";
                }
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsql = "select *from articulo where cod_art='" + articulo.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    descripcion.Text = leer["des_art"].ToString();
                    precio.Text = leer["pre_art"].ToString();
                }
                else
                {
                    descripcion.Text = "No encontrado";
                }
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        public DataTable llenar_gridDF()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT *FROM detallefactura order by cod_art desc";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal subtotal, pre, can;

                pre = Convert.ToDecimal(precio.Text);
                can = Convert.ToDecimal(cantidad.Text);

                subtotal = (pre * can);
                subtot.Text = subtotal.ToString();

                // Inserción en la tabla temporal
                {
                    Conexion.Conectar();
                    string insertar = "INSERT INTO Temdetallefactura(num_fac, cod_art, des_art, pre_art, can_art, sub_tot) VALUES(@num_fac, @cod_art, @des_art, @pre_art, @can_art, @sub_tot)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@num_fac", numfactura.Text);
                    cmd1.Parameters.AddWithValue("@cod_art", articulo.Text);
                    cmd1.Parameters.AddWithValue("@des_art", descripcion.Text);
                    cmd1.Parameters.AddWithValue("@pre_art", precio.Text);
                    cmd1.Parameters.AddWithValue("@can_art", cantidad.Text);
                    cmd1.Parameters.AddWithValue("@sub_tot", subtot.Text);
                    cmd1.ExecuteNonQuery();
                }

                // Inserción en la tabla detallefactura
                {
                    Conexion.Conectar();
                    string insertar = "INSERT INTO detallefactura(num_fac, cod_art, des_art, pre_art, can_art, sub_tot) VALUES(@num_fac, @cod_art, @des_art, @pre_art, @can_art, @sub_tot)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@num_fac", numfactura.Text);
                    cmd1.Parameters.AddWithValue("@cod_art", articulo.Text);
                    cmd1.Parameters.AddWithValue("@des_art", descripcion.Text);
                    cmd1.Parameters.AddWithValue("@pre_art", precio.Text);
                    cmd1.Parameters.AddWithValue("@can_art", cantidad.Text);
                    cmd1.Parameters.AddWithValue("@sub_tot", subtot.Text);
                    cmd1.ExecuteNonQuery();
                }

                // Disminuir el inventario
                {
                    Conexion.Conectar();
                    string cadena = "UPDATE Articulo SET exi_art = exi_art - @cantidad WHERE cod_art = @cod_art";
                    SqlCommand comando1 = new SqlCommand(cadena, Conexion.Conectar());
                    comando1.Parameters.AddWithValue("@cantidad", cantidad.Text);
                    comando1.Parameters.AddWithValue("@cod_art", articulo.Text);
                    comando1.ExecuteNonQuery();
                }

                // Actualizar el DataGridView
                // Limpiar el DataGridView antes de cargar nuevos datos
                TDF.DataSource = null; // Limpiar filas del DataGridView
                TDF.DataSource = llenar_gridDF();
                // Sumar la columna sub total
                double stf = 0;
                foreach (DataGridViewRow row in TDF.Rows)
                {
                    stf += Convert.ToDouble(row.Cells["sub_tot"].Value);
                }
                subtotfac.Text = Convert.ToString(stf);

                // Sumar la columna sub total a pagar
                double tap = 0;
                foreach (DataGridViewRow row in TDF.Rows)
                {
                    tap += Convert.ToDouble(row.Cells["sub_tot"].Value);
                }
                totalapagar.Text = Convert.ToString(tap);

                // Limpiar los campos de entrada
                articulo.Text = "";
                descripcion.Text = "";
                cantidad.Text = "";
                precio.Text = "";
                subtot.Text = "";

                

                // Manejo del evento para avanzar al siguiente control
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        

        private void guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subtotfac.Text))
            {
                MessageBox.Show("No hay Factura para Procesar");
                articulo.Focus();
                return;
            }

            Conexion.Conectar();
            string insertar = "INSERT INTO Factura(num_fac,hor_fac,fec_fac,cod_cli,tip_fac,nom_cli,sub_tot_fac,des_fac,itb_fac,tot_fac,pdf_fac,pit_fac) " +
                              "VALUES (@num_fac,@hor_fac,@fec_fac,@cod_cli,@tip_fac,@nom_cli,@sub_tot_fac,@des_fac,@itb_fac,@tot_fac,@pdf_fac,@pit_fac)";

            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());

            cmd1.Parameters.AddWithValue("@num_fac", numfactura.Text.Trim());
            cmd1.Parameters.AddWithValue("@hor_fac", hora.Text.Trim());
            cmd1.Parameters.AddWithValue("@fec_fac", fecha.Text.Trim());
            cmd1.Parameters.AddWithValue("@cod_cli", cliente.Text.Trim());
            cmd1.Parameters.AddWithValue("@tip_fac", tipodefactura.Text.Trim());
            cmd1.Parameters.AddWithValue("@nom_cli", nombre.Text.Trim());

            // Conversión segura de valores numéricos
            decimal.TryParse(subtotfac.Text, out decimal subTotal);
            decimal.TryParse(daf.Text, out decimal descuento);
            decimal.TryParse(itbis.Text, out decimal itbisValue);
            decimal.TryParse(totalapagar.Text, out decimal total);
            decimal.TryParse(pdf.Text, out decimal pdfValue);
            decimal.TryParse(pitbis.Text, out decimal pitbisValue);

            cmd1.Parameters.AddWithValue("@sub_tot_fac", subTotal);
            cmd1.Parameters.AddWithValue("@des_fac", descuento);
            cmd1.Parameters.AddWithValue("@itb_fac", itbisValue);
            cmd1.Parameters.AddWithValue("@tot_fac", total);
            cmd1.Parameters.AddWithValue("@pdf_fac", pdfValue);
            cmd1.Parameters.AddWithValue("@pit_fac", pitbisValue);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");

            guardar.Enabled = false;
        }
    

        private void pdf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal pddf = 0;
                decimal dalf = 0;
                decimal stf = 0;
                decimal tf = 0;
                decimal itb = 0;
                stf = Convert.ToDecimal(subtotfac.Text);
                pddf = Convert.ToDecimal(pdf.Text);
                itb = Convert.ToDecimal(itbis.Text);
                dalf = stf * (pddf / 100);
                daf.Text = dalf.ToString();
                tf = (stf - dalf) + itb;
                totalapagar.Text = tf.ToString();
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void pitbis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal pitb = 0;
                decimal iaf = 0;
                decimal daaf = 0;
                decimal stf = 0;
                decimal tif = 0;
                decimal tf = 0;
                decimal stnf = 0;
                daaf = Convert.ToDecimal(daf.Text);
                stf = Convert.ToDecimal(subtotfac.Text);
                pitb = Convert.ToDecimal(pitbis.Text);
                iaf = stf - daaf;
                tif = iaf * (pitb / 100);
                itbis.Text = tif.ToString();
                stnf = stf - daaf;
                tf = stnf + tif;
                totalapagar.Text = tf.ToString();

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            F3P rn = new F3P();
            rn.numero.Text = this.numfactura.Text;
            rn.ShowDialog();
        }
    }
}
