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

namespace SistemaCotizacionArticulos.UI.Registros
{
    public partial class RegistroExistencia : Form
    {
       

        public RegistroExistencia()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            LimpiarCampos();
        }

        private ExistenciaArticulo LlenaClase()
        {
            ExistenciaArticulo existencia = new ExistenciaArticulo()
            {
                ArticuloID = Convert.ToInt32(IDnumericUpDown.Value),
                Descripcion = descripcionTextBox.Text,
                Existencia = Convert.ToInt32(existenciaTextBox.Text),
            };
            return existencia;
        }

        private void LlenaCampo(ExistenciaArticulo existencia)
        {
            IDnumericUpDown.Value = existencia.ArticuloID;
            descripcionTextBox.Text = existencia.Descripcion;
            existenciaTextBox.Text = Convert.ToString(existencia.Existencia);
          
        }
        
        

        private void LimpiarCampos()
        {
            errorProvider.Clear();
            IDnumericUpDown.Value = 0;
            descripcionTextBox.Text = string.Empty;
            existenciaTextBox.Text = String.Empty;


        }
        /*
        private bool Existe()
        {
            ExistenciaArticulo existencia = ExistenciaArticuloBLL.Buscar((int)IDnumericUpDown.Value);
            return (existencia != null);
        }


        public bool Validar()
        {
            bool paso = true;

            if (String.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                errorProvider.SetError(descripcionTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
         
            if (String.IsNullOrWhiteSpace(existenciaTextBox.Text))
            {
                errorProvider.SetError(existenciaTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
        

            return paso;
        }*/

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            /*
            ExistenciaArticulo existencia;
            bool paso = false;
            if (!Validar())
                return;

            existencia = LlenaClase();

            if (IDnumericUpDown.Value == 0)
                paso = ExistenciaArticuloBLL.Guardar(existencia);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("Error al modificar el registro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ExistenciaArticuloBLL.Modificar(existencia);
            }

            if (paso)
            {
                MessageBox.Show("Guardado Exitosamente !!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
                MessageBox.Show("Error al Guardar!!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                */
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*
            errorProvider.Clear();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            if (!Existe())
            {
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar un Articulo Inexistente");
                return;
            }
            if (ExistenciaArticuloBLL.Eliminar(id))
            {
                LimpiarCampos();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*
            int id;
            ExistenciaArticulo existencia = new ExistenciaArticulo();
            int.TryParse(IDnumericUpDown.Text, out id);
            existencia = ExistenciaArticuloBLL.Buscar(id);

            if (existencia != null)
            {
                errorProvider.Clear();
                LlenaCampo(existencia);
                MessageBox.Show("Existencia Encontrada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Existancia no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        */
        }
    }
}
