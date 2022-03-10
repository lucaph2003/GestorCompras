using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_compras.Acceso_a_datos
{
    class conexionBD
    {
            public static string database { get; private set; }

            public static MySqlConnection getConexion()
            {
                //Metodo para obtener la conexion a la base de datos
                string servidor = "127.0.0.1";
                string puerto = "3306";
                string usuario = "root";
                string password = "root";
                string bd = "gestor";

                string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

                MySqlConnection conexion = new MySqlConnection(cadenaConexion);

                return conexion;
            }
            public static void openConexion()
            {
                //Metodo para abrir base de datos
                MySqlConnection conexion = conexionBD.getConexion();
                conexion.Open();
            }

        public static void closeConexion()
        {
            //Metodo para cerrar base de datos
            MySqlConnection conexion = conexionBD.getConexion();
            conexion.Close();
        }
    }
}
