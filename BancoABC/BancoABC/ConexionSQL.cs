using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BancoABC
{
    class ConexionSQL
    {

        public static MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "root";
            string bd = "cajero";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }
    }

}
