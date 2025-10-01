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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void CanMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultarA = "Select * from Articulo where des_art like('" + busqueda.Text + "%')";
            SqlCommand cmd4 = new SqlCommand(consultarA, Conexion.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            aa.DataSource = dt;

        }



        private void to_KeyPress(object sender, KeyPressEventArgs e)
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
            this.Descripcion.Focus();

            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(Cast(cod_art as int)),0)+1 from Articulo", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigo.Text = dt.Rows[0][0].ToString();
        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            aa.DataSource = actualizararticulos();

            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(cod_art as int)),0)+1 from Articulo", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigo.Text = dt.Rows[0][0].ToString();

            int Total = int.Parse(aa.RowCount.ToString());
            tota.Text = Convert.ToString(Total - 1);
        }


        public DataTable actualizararticulos()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Articulo order by cod_art desc";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;

        }



        private void guardar_Click(object sender, EventArgs e)
        {

            Conexion.Conectar();
            string insertar = "INSERT INTO Articulo(cod_art,des_art,cos_art,pre_art,can_art,exi_art,can_min)VALUES(@cod_art,@des_art,@cos_art,@pre_art,@can_art,@exi_art,@can_min)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_art", Codigo.Text);
            cmd1.Parameters.AddWithValue("@des_art", Descripcion.Text);
            cmd1.Parameters.AddWithValue("@cos_art", Costo.Text);
            cmd1.Parameters.AddWithValue("@pre_art", Precio.Text);
            cmd1.Parameters.AddWithValue("@can_art", Cantidad.Text);
            cmd1.Parameters.AddWithValue("@exi_art", Existencia.Text);
            cmd1.Parameters.AddWithValue("@can_min", CanMinima.Text);
            cmd1.ExecuteNonQuery();
            aa.DataSource = actualizararticulos();



            MessageBox.Show("Datos agregados con éxito");

            int Total = int.Parse(aa.RowCount.ToString());
            tota.Text = Convert.ToString(Total - 1);
        }


        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsql = "select *from Articulo where cod_art=" + Codigo.Text + "";
                SqlCommand comando = new SqlCommand(cadsql, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {

                    Descripcion.Text = leer["des_art"].ToString();
                    Costo.Text = leer["cos_art"].ToString();
                    Precio.Text = leer["pre_art"].ToString();
                    Cantidad.Text = leer["can_art"].ToString();
                    Existencia.Text = leer["exi_art"].ToString();
                    CanMinima.Text = leer["can_min"].ToString();
                }
                else
                {
                    Descripcion.Text = "Registro no encontrado";
                }
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Articulo Where cod_art = @cod_art";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@cod_art", Codigo.Text);
                cmd3.ExecuteNonQuery();
                aa.DataSource = actualizararticulos();

                int Total = int.Parse(aa.RowCount.ToString());
                tota.Text = Convert.ToString(Total - 1);
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = Conexion.Conectar();
                string cadena = "UPDATE Articulo SET des_art = @des_art, " +
                                "cos_art = @cos_art, pre_art = @pre_art, " +
                                "can_art = @can_art, exi_art = @exi_art, " +
                                "can_min = @can_min WHERE cod_art = @cod_art";

                using (SqlCommand comando = new SqlCommand(cadena, conexion))
                {
                    comando.Parameters.AddWithValue("@des_art", Descripcion.Text);
                    comando.Parameters.AddWithValue("@cos_art", Convert.ToInt32(Costo.Text));
                    comando.Parameters.AddWithValue("@pre_art", Convert.ToInt32(Precio.Text));
                    comando.Parameters.AddWithValue("@can_art", Convert.ToInt32(Cantidad.Text));
                    comando.Parameters.AddWithValue("@exi_art", Convert.ToInt32(Existencia.Text));
                    comando.Parameters.AddWithValue("@can_min", Convert.ToInt32(CanMinima.Text));
                    comando.Parameters.AddWithValue("@cod_art", Convert.ToInt32(Codigo.Text));

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Los datos fueron actualizados con exito.");
                    }
                    
                }

                aa.DataSource = actualizararticulos();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el artículo: " + ex.Message);
            }
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            RA rpc = new RA();
            rpc.Show();
        }
    }
}










