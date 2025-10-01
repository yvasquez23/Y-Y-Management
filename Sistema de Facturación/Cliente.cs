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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void codigo_Click(object sender, EventArgs e)
        {

        }

        private void sector_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'factura.Cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.factura.Cliente);

            ac.DataSource = actualizarclientes();

            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(cod_cli as int)),0)+1 from Cliente", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigo.Text = dt.Rows[0][0].ToString();

            int Total = int.Parse(ac.RowCount.ToString());
            tota.Text = Convert.ToString(Total - 1);
        }

        private void Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Sector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Provincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultarA = "Select * from cliente where nom_cli like('" + busqueda.Text + "%')";
            SqlCommand cmd4 = new SqlCommand(consultarA, Conexion.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            ac.DataSource = dt;
        }

        private void Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)

                {
                    ctrl.Text = "";
                }
                if (ctrl is ComboBox)

                    ctrl.Text = "";
            }
            this.Nombres.Focus();

            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(Cast(cod_cli as int)),0)+1 from Cliente", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigo.Text = dt.Rows[0][0].ToString();
        }


        public DataTable actualizarclientes()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * fROM cliente order by cod_cli desc";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Cliente(cod_cli,nom_cli,ape_cli,dir_cli,sec_cli,pro_cli,con_cli,cor_cli)VALUES(@cod_cli,@nom_cli,@ape_cli,@dir_cli,@sec_cli,@pro_cli,@con_cli,@cor_cli)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_cli", Codigo.Text);
            cmd1.Parameters.AddWithValue("@nom_cli", Nombres.Text);
            cmd1.Parameters.AddWithValue("@ape_cli", Apellidos.Text);
            cmd1.Parameters.AddWithValue("@dir_cli", Direccion.Text);
            cmd1.Parameters.AddWithValue("@sec_cli", Sector.Text);
            cmd1.Parameters.AddWithValue("@pro_cli", Provincia.Text);
            cmd1.Parameters.AddWithValue("@con_cli", Contacto.Text);
            cmd1.Parameters.AddWithValue("@cor_cli", Correo.Text);
            cmd1.ExecuteNonQuery();
            ac.DataSource = actualizarclientes();


            MessageBox.Show("Datos agregados con éxito");

            int Total = int.Parse(ac.RowCount.ToString());
            tota.Text = Convert.ToString(Total - 1);
        }
        
        
        private void ac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsql = "select *from Cliente where cod_cli=" + Codigo.Text + "";
                SqlCommand comando = new SqlCommand(cadsql, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {

                    Nombres.Text = leer["nom_cli"].ToString();
                    Apellidos.Text = leer["ape_cli"].ToString();
                    Direccion.Text = leer["dir_cli"].ToString();
                    Sector.Text = leer["sec_cli"].ToString();
                    Provincia.Text = leer["pro_cli"].ToString();
                    Contacto.Text = leer["con_cli"].ToString();
                    Correo.Text = leer["cor_cli"].ToString();
                }
                else
                {
                    Nombres.Text = "Registro no encontrado";
                }
                e.Handled = true;
                SendKeys.Send("{TAB}");
           }
        }

       private void modificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string cadena = "update cliente set nom_cli = '" + Nombres.Text + "', ape_cli='" + Apellidos.Text + "', sec_cli='" + Sector.Text + "', pro_cli='" + Provincia.Text + "', con_cli='" + Contacto.Text + "', cor_cli= '" + Correo.Text + "' Where Cod_cli= " + Codigo.Text + "";

            SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
            comando.ExecuteNonQuery();
            ac.DataSource = actualizarclientes();

            MessageBox.Show("Los datos fueron actualizados con exito."); 

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Cliente Where cod_cli = @cod_cli";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@cod_cli", Codigo.Text);
                cmd3.ExecuteNonQuery();
                ac.DataSource = actualizarclientes();

                int Total = int.Parse(ac.RowCount.ToString());
                tota.Text = Convert.ToString(Total - 1);
            }
            
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            RCN drpc = new RCN();
            drpc.Show();
        }
    }

            
            
}
