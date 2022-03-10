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
    public partial class frmGanancias : Form
    {
        public frmGanancias()
        {
            InitializeComponent();
            int codigo;
            string mensaje;
            lblGanancias.Text = Compras.sumaTotal(out codigo,out mensaje).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
