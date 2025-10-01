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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                    
                    Conexion.Conectar();
                    string consulta = "SELECT * FROM usuario WHERE nom_usu = @usuario AND cla_usu = @clave";
                    SqlCommand comando = new SqlCommand(consulta, Conexion.Conectar());
                    comando.Parameters.AddWithValue("@usuario", Usuario.Text);
                    comando.Parameters.AddWithValue("@clave", Contraseña.Text);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read()) 
                    {
                        MessageBox.Show("Bienvenido al sistema");

                        Menu frm = new Menu();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña incorrecta");
                        this.Usuario.Text = "";
                        this.Contraseña.Text = "";
                        this.Usuario.Focus();
                    }

                    lector.Close();
                }


                private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }
    }
}
    

    
   