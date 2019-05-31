using PrimerProyecto.BLL;
using PrimerProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto.UI.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();

            producto.ProductoId = Convert.ToInt32(IdNumericUpDown.Value);
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);
            producto.Costo = Convert.ToInt32(CostoTextBox.Text);
            producto.ValorInventario = Convert.ToInt32(VInventarioTextBox.Text);

            return producto;
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            ExistenciaTextBox.Clear();
            CostoTextBox.Clear();
            VInventarioTextBox.Clear();
        }

        private bool Validar()
        {
            bool estado = false;

            if (IdNumericUpDown.Value < 0)
            {
                MyErrorProvider.SetError(DescripcionTextBox,
                    "No es un id válido");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(CostoTextBox.Text))
            {
                MyErrorProvider.SetError(CostoTextBox,
                    "No puede estar vacio");
                estado = true;
            }

            if (String.IsNullOrWhiteSpace(ExistenciaTextBox.Text))
            {
                MyErrorProvider.SetError(ExistenciaTextBox,
                    "No puede estar vacio");
                estado = true;
            }
            if (ExistenciaTextBox.Text.Any(x => !char.IsNumber(x)))
            {
                MyErrorProvider.SetError(ExistenciaTextBox,
                    "Solo puede ingresar números");
                estado = true;
            }
            if (CostoTextBox.Text.Any(x => !char.IsNumber(x)))
            {
                MyErrorProvider.SetError(CostoTextBox,
                    "Solo puede ingresar números");
                estado = true;
            }

            return estado;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdNumericUpDown.Value);
            Productos producto = ProductosBLL.Buscar(id);

            if (producto != null)
            {
                DescripcionTextBox.Text = producto.Descripcion;
                CostoTextBox.Text = producto.Costo.ToString();
                ExistenciaTextBox.Text = producto.Existencia.ToString();
                VInventarioTextBox.Text = producto.ValorInventario.ToString();
            }
            else
                MessageBox.Show("No se encontró", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Debe llenar todos los campos que se indican!!!", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            producto = LlenaClase();

            if (IdNumericUpDown.Value == 0)
                Paso = ProductosBLL.Guardar(producto);
            else
            {
                int id = Convert.ToInt32(IdNumericUpDown.Value);
                producto = ProductosBLL.Buscar(id);

                if (producto != null)
                {
                    Paso = ProductosBLL.Modificar(LlenaClase());
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Paso)
            {
                MessageBox.Show("Guardado", "Exito",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdNumericUpDown.Value);

            Productos producto = ProductosBLL.Buscar(id);

            if (producto != null)
            {
                if (ProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Calcular()
        {
            int val;
            bool result = int.TryParse(ExistenciaTextBox.Text, out val);
            if (!result)
                return;

            int valor;
            bool resulta = int.TryParse(CostoTextBox.Text, out valor);
            if (!result)
                return;

            int costo = Convert.ToInt32(val);
            int existencia = Convert.ToInt32(valor);

            VInventarioTextBox.Text = ProductosBLL.CalcularVI(existencia,costo).ToString();
        }

        private void CostoTextBox_TextChanged(object sender, EventArgs e)
        {

            if (ExistenciaTextBox.Text != "")
            {
                Calcular();
            }
        }

        private void ExistenciaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CostoTextBox.Text != "")
            {
                Calcular();
            }
        }
    }
}
