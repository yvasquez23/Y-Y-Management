using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Facturación
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(@"SERVER=DESKTOP-1SNC7GU\SQLEXPRESS;DATABASE=Facturacion;Integrated Security= true");

            cn.Open();
            return cn;
        }

    }
}
