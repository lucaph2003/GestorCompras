using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestor_de_compras.Logica;
using System.Collections;

namespace Gestor_de_compras.Acceso_a_datos
{
    class comprasBD
    {
        public static void RegistrarCompra(Compras compras,out int codigo, out string mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = conexionBD.getConexion();
                conexion.Open();

                string sql = "INSERT INTO pedido (fecha,cantidad_productos,inversion,ganancia, envio) VALUES(@fecha, @cantidad_productos, @inversion, @ganancia, @envio)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@fecha", compras.Fecha);
                comando.Parameters.AddWithValue("@cantidad_productos", compras.CantidadProductos);
                comando.Parameters.AddWithValue("@inversion", compras.Inversion);
                comando.Parameters.AddWithValue("@ganancia", compras.Ganancia);
                comando.Parameters.AddWithValue("@envio", compras.Envio);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se han registrado el alumno correctamente.";
            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el alumno. " + ex.ToString();
            }
        }

        public ArrayList ListarCompras()
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = conexionBD.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM pedido ";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Compras compras = null;
                    compras = new Compras();
                    compras.Fecha = DateTime.Parse(reader["fecha"].ToString()); ;
                    compras.CantidadProductos = int.Parse(reader["cantidad_productos"].ToString());
                    compras.Inversion = int.Parse(reader["inversion"].ToString());
                    compras.Ganancia = int.Parse(reader["ganancia"].ToString());
                    compras.Envio = bool.Parse(reader["envio"].ToString());
                    lista.Add(compras);
                }
                conexionBD.closeConexion();
            }
            catch (MySqlException ex) { }

            return lista;
        }

        public List<Compras> TotalGanancia(out int codigo,out string mensaje)
        {
            List<Compras> MiLista = new List<Compras>();
            codigo = 1;
            mensaje = "";
            int id = 0;
            try
            {
                MySqlConnection conexion = conexionBD.getConexion();
                conexion.Open();
                string sql = "SELECT SUM(ganancia) FROM pedido AS monto WHERE idpedido > @id";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idpedido", id);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Compras compras = null;
                    compras = new Compras();
                    compras.Fecha = DateTime.Parse(reader["fecha"].ToString()); ;
                    compras.CantidadProductos = int.Parse(reader["cantidad_productos"].ToString());
                    compras.Inversion = int.Parse(reader["inversion"].ToString());
                    compras.Ganancia = int.Parse(reader["ganancia"].ToString());
                    compras.Envio = bool.Parse(reader["envio"].ToString());
                    compras.Monto = int.Parse(reader["monto"].ToString());
                    MiLista.Add(compras);
                }

                reader.Close();
            }
            catch (MySqlException ex) { }

            return MiLista;
        }

        public int TotalInversion(int sumaTotal, out int codigo, out string mensaje)
        {
            codigo = 1;
            mensaje = "";
            sumaTotal = 0;
            try
            {
                MySqlConnection conexion = conexionBD.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT SUM(inversion) FROM pedido";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                conexionBD.closeConexion();
            }
            catch (MySqlException ex) { }

            return sumaTotal;
        }
        public int TotalGananciaUltimoMes(int sumaTotal,DateTime mesActual, out int codigo, out string mensaje)
        {
            codigo = 1;
            mensaje = "";
            sumaTotal = 0;
            try
            {
                MySqlConnection conexion = conexionBD.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT SUM(ganancia) FROM pedido WHERE fecha=@mesactual";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                conexionBD.closeConexion();
            }
            catch (MySqlException ex) { }

            return sumaTotal;
        }
        public int TotalInversionUltimoMes(int sumaTotal, out int codigo, out string mensaje)
        {
            codigo = 1;
            mensaje = "";
            sumaTotal = 0;
            try
            {
                MySqlConnection conexion = conexionBD.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT SUM(inversion) FROM pedido";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();

                conexionBD.closeConexion();
            }
            catch (MySqlException ex) { }

            return sumaTotal;
        }
    }
}
