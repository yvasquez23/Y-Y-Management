using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Facturación
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void rm_Enter(object sender, EventArgs e)
        {

        }

        private void art_Click(object sender, EventArgs e)
        {
            Articulo frm = new Articulo();
            frm.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Entrada frm = new Entrada();
            frm.Show();
            this.Close();
        }

        private void Cli_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.Show();
        }

        private void Us_Click(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            frm.Show();
        }

        private void fac_Click(object sender, EventArgs e)
        {
            Facturacion frm = new Facturacion();
            frm.Show();
        }
    }
}
