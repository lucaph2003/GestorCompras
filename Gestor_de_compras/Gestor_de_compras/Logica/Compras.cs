using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestor_de_compras.Acceso_a_datos;
using System.Collections;

namespace Gestor_de_compras.Logica
{
    class Compras
    {
        int id,inversion, cantidadProductos,ganancia,monto;
        DateTime fecha;
        bool envio;
        public int Id { get => id; set => id = value; }
        public int Inversion { get => inversion; set => inversion = value; }
        public int Ganancia { get => ganancia; set => ganancia = value; }
        public int CantidadProductos { get => cantidadProductos; set => cantidadProductos = value; }
        public int Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Envio { get => envio; set => envio = value; }

       public string mostrarfecha()
        {
            return Fecha.Date.Day + "/" + Fecha.Date.Month + "/" + Fecha.Date.Year;
        }
        public void registroCompra(int pcantidadProductos,int pInversion,int pGanancia, DateTime pFecha, bool pEnvio, out int codigo, out String mensaje)
        {
                Compras compras = new Compras();
                compras.CantidadProductos = pcantidadProductos;
                compras.Inversion = pInversion;
                compras.Ganancia = pGanancia;
                compras.Fecha = pFecha;
                compras.Envio = pEnvio;

                comprasBD.RegistrarCompra(compras, out  codigo, out  mensaje);

        }

        public static ArrayList listarCompras()
        {
            ArrayList lista = new ArrayList();

            comprasBD comprasbd = new comprasBD();

            return comprasbd.ListarCompras();
        }

        public static List<Compras> sumaTotal(out int codigo , out string mensaje)
        {
            comprasBD compra = new comprasBD();
            return compra.TotalGanancia(out codigo,out mensaje);
        }

    }
}
