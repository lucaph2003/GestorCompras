using System;
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
    public partial class frmNuevaCompra : Form
    {
        public frmNuevaCompra()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool envio;
            if(checkBoxEnvio.Checked)
            {
                envio = true;
            }else
            {
                envio = false;
            }
            DateTime dtp = dateTime.Value.Date;
            Compras compra = new Compras();
            int CantProductos = int.Parse(txtCantProductos.Text.ToString());
            int Monto = int.Parse(txtMonto.Text.ToString());
            int Ganancia = int.Parse(txtGanancia.Text.ToString());
            compra.registroCompra(CantProductos,Monto,Ganancia,dtp,envio, out int codigo, out String mensaje);
            if (codigo == 1)
            {
                MessageBox.Show("Se ha registrado con exito! ! ! ");
            }
            else
            {
                MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
