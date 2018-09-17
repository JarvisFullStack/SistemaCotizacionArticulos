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
    public partial class RegistroArticulo : Form
    {
        public RegistroArticulo()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private Articulo LlenaClase()
        {
            Articulo articulo = new Articulo()
            {
                ArticuloId = Convert.ToInt32(IDNumericUpDown.Value),
                Descripcion = DescripcionTextBox.Text,
                Precio = Convert.ToSingle(PrecioTextBox.Text),
                Existencia = Convert.ToInt32(ExistenciaTextBox.Text),
                CantidadCotizada = Convert.ToInt32(CantidadNumericUpDown.Value),
                FechaVencimiento = FechaVencimientoDateTImePicker.Value
            };
            return articulo;
        }

        private void LlenaCampo(Articulo articulo)
        {
            
            IDNumericUpDown.Value = articulo.ArticuloId;
            DescripcionTextBox.Text = articulo.Descripcion;
            PrecioTextBox.Text = Convert.ToString(articulo.Precio);
            ExistenciaTextBox.Text = Convert.ToString(articulo.Existencia);
            CantidadNumericUpDown.Text = Convert.ToString(articulo.CantidadCotizada);
            FechaVencimientoDateTImePicker.Value = articulo.FechaVencimiento;
        }
        private bool Existe()
        {
            Articulo articulo = ArticulosBLL.Buscar((int)IDNumericUpDown.Value);
            return (articulo != null);
        }


        private void LimpiarCampos()
        {
            errorProvider.Clear();
            IDNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = String.Empty;
            ExistenciaTextBox.Text = String.Empty;
            CantidadNumericUpDown.Text = String.Empty;
            FechaVencimientoDateTImePicker.Value = DateTime.Now;

        }

         public bool Validar(){
            bool paso = true;

            if(String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                errorProvider.SetError(DescripcionTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
            if(String.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                errorProvider.SetError(PrecioTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
            if(String.IsNullOrWhiteSpace(ExistenciaTextBox.Text))
            {
                errorProvider.SetError(ExistenciaTextBox, "No puede dejar este campo Vacio");
                paso = false;
            }
            if(String.IsNullOrWhiteSpace(CantidadNumericUpDown.Text))
            {
                errorProvider.SetError(CantidadNumericUpDown, "No puede dejar este campo Vacio");
                paso = false;
            }

            return paso;
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            Articulo articulo;
            bool paso = false;
            if (!Validar())
                return;

            articulo = LlenaClase();

            if (IDNumericUpDown.Value == 0)
                paso = ArticulosBLL.Guardar(articulo);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("Error al modificar el registro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ArticulosBLL.Modificar(articulo);
            }

            if (paso)
            {
                MessageBox.Show("Guardado Exitosamente !!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
                MessageBox.Show("Error al Guardar!!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            if (!Existe())
            {
                errorProvider.SetError(IDNumericUpDown, "No se puede eliminar un Articulo Inexistente");
                return;
            }
            if (ArticulosBLL.Eliminar(id))
            {
                LimpiarCampos();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            Articulo articulo = new Articulo();
            ExistenciaArticulo existencia = new ExistenciaArticulo();
            int.TryParse(IDNumericUpDown.Text, out id);
            articulo = ArticulosBLL.Buscar(id);
            


            if (articulo != null)
            {
                errorProvider.Clear();
                LlenaCampo(articulo);
                MessageBox.Show("Articulo Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Articulo no Encontrado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroExistencia registroExistencia = new RegistroExistencia();
            registroExistencia.MdiParent = MainForm.ActiveForm;
            registroExistencia.Show();
        }
    }
}
