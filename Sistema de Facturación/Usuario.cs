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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void ConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Celular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultarA = "Select * from Usuario where nom_usu like('" + busqueda.Text + "%')";
            SqlCommand cmd4 = new SqlCommand(consultarA, Conexion.Conectar());
            cmd4.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            da.Fill(dt);
            au.DataSource = dt;
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
            this.Nombre.Focus();

            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(Cast(cod_usu as int)),0)+1 from Usuario", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigo.Text = dt.Rows[0][0].ToString();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'factura.Usuario' Puede moverla o quitarla según sea necesario.
            //this.usuarioTableAdapter.Fill(this.factura.Usuario);

            au.DataSource = actualizarusuarios();

            Conexion.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(cod_usu as int)),0)+1 from Usuario", Conexion.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Codigo.Text = dt.Rows[0][0].ToString();

            int Total = int.Parse(au.RowCount.ToString());
            tota.Text = Convert.ToString(Total - 1);
        }





        public DataTable actualizarusuarios()
        {

            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Usuario WHERE nom_usu <> 'Admin' ORDER BY cod_usu DESC";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
           

            da.Fill(dt);
            return dt;
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Usuario(cod_usu,nom_usu,cla_usu,cel_usu,cor_usu)VALUES(@cod_usu,@nom_usu,@cla_usu,@cel_usu,@cor_usu)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_usu", Codigo.Text);
            cmd1.Parameters.AddWithValue("@nom_usu", Nombre.Text);
            cmd1.Parameters.AddWithValue("@cla_usu", Clave.Text);
            cmd1.Parameters.AddWithValue("@con_cla", ConfirmarClave.Text);
            cmd1.Parameters.AddWithValue("@cel_usu", Celular.Text);
            cmd1.Parameters.AddWithValue("@cor_usu", Correo.Text);
            cmd1.ExecuteNonQuery();
            au.DataSource = actualizarusuarios();


            MessageBox.Show("Datos agregados con éxito");

            int Total = int.Parse(au.RowCount.ToString());
            tota.Text = Convert.ToString(Total - 1);
        }

        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion.Conectar();
                string cadsql = "select *from Usuario where cod_usu=" + Codigo.Text + "";
                SqlCommand comando = new SqlCommand(cadsql, Conexion.Conectar());

                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {

                    Nombre.Text = leer["nom_usu"].ToString();
                    Clave.Text = leer["cla_usu"].ToString();
                    ConfirmarClave.Text = leer["con_cla"].ToString();
                    Celular.Text = leer["cel_usu"].ToString();
                    Correo.Text = leer["cor_usu"].ToString();
                }
                else
                {
                    Nombre.Text = "Registro no encontrado";
                }
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string cadena = "update Usuario set nom_usu = '" + Nombre.Text + "', cla_usu='" + Clave.Text + "', con_cla='" + ConfirmarClave.Text + "', cel_usu='" + Celular.Text + "', cor_usu='" + Correo.Text + "' Where Cod_usu= " + Codigo.Text + "";

            SqlCommand comando = new SqlCommand(cadena, Conexion.Conectar());
            comando.ExecuteNonQuery();
            au.DataSource = actualizarusuarios();

            MessageBox.Show("Los datos fueron actualizados con exito");
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Usuario Where cod_usu = @cod_usu";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@cod_usu", Codigo.Text);
                cmd3.ExecuteNonQuery();
                au.DataSource = actualizarusuarios();

                int Total = int.Parse(au.RowCount.ToString());
                tota.Text = Convert.ToString(Total - 1);
            }
        }

        private void au_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            RU rpc = new RU();
            rpc.Show();

        }
    }
    }

    
    

