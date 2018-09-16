using SistemaCotizacionArticulos.UI.Consultas;
using SistemaCotizacionArticulos.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCotizacionArticulos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cotizarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulo registroArticulo = new RegistroArticulo();
            registroArticulo.MdiParent = this;
            registroArticulo.Show();

        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaArticulo consultaArticulo = new ConsultaArticulo();
            consultaArticulo.MdiParent = this;
            consultaArticulo.Show();
        }
    }
}
