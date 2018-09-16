using SistemaCotizacionArticulos.BLL;
using SistemaCotizacionArticulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCotizacionArticulos.UI.Consultas
{
    public partial class ConsultaArticulo : Form
    {
        public ConsultaArticulo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listado = new List<Articulo>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {

                    case 0:
                        listado = ArticulosBLL.GetList(p => true);
                        break;
                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = ArticulosBLL.GetList(p => p.ArticuloId == id);
                        break;

                    case 2:
                        listado = ArticulosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }

                listado = listado.Where(x => x.FechaVencimiento.Date >= DesdeDateTimePicker.Value.Date && x.FechaVencimiento.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = ArticulosBLL.GetList(p => true);
            }


            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
