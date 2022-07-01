using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestor_de_compras.Logica;

namespace Gestor_de_compras.UI
{
    public partial class frmRegistroProducto : Form
    {
        public frmRegistroProducto()
        {
            InitializeComponent();

            ArrayList listaCompras = Compras.listarCompras();
            foreach (Compras com in listaCompras)
            {
                ListViewItem items = new ListViewItem(com.mostrarfecha());
                items.SubItems.Add("$" + com.Inversion.ToString());
                items.SubItems.Add("x" + com.CantidadProductos.ToString());
                listCompras.Items.Add(items);
            }
        }

        private void listCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
