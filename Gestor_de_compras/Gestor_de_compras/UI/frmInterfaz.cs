using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_compras.UI
{
    public partial class frmInterfaz : Form
    {
        public frmInterfaz()
        {
            InitializeComponent();
        }

        private void pboCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormhija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void pboMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmRegistroProducto());
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmNuevaCompra());
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmGanancias());
        }
    }
}
