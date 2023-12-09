using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoMDS_Centroedu
{
    internal class Conexion
    {
        public static MySqlConnection conexion()
        {
            String servidor = "centroedu.chxxdzkjdesc.us-east-2.rds.amazonaws.com";
            String puerto = "3306";
            String usuario = "admin";
            String password = "administrador";
            String bd = "centroedu";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port = " + puerto + "; User id =" + usuario + "; Password =" + password;



            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}
