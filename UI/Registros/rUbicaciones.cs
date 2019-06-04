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
    public partial class rUbicaciones : Form
    {
        public rUbicaciones()
        {
            InitializeComponent();
        }

        private Ubicaciones LlenaClase()
        {
            Ubicaciones ubicacion = new Ubicaciones();

            ubicacion.UbicacionId = Convert.ToInt32(IdNumericUpDown.Value);
            ubicacion.Descripcion = DescripcionTextBox.Text;

            return ubicacion;
        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
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

            return estado;



        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdNumericUpDown.Value);
            Ubicaciones ubicaciones = UbicacionesBLL.Buscar(id);

            if (ubicaciones != null)
            {
                DescripcionTextBox.Text = ubicaciones.Descripcion;
            }
            else
                MessageBox.Show("No se encontró", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicacion = new Ubicaciones();
            bool Estado = false;

            if (Validar())
                return;

                ubicacion = LlenaClase();

                if (IdNumericUpDown.Value == 0)
                    Estado = UbicacionesBLL.Guardar(ubicacion);
                else
                {
                    int id = Convert.ToInt32(IdNumericUpDown.Value);
                    ubicacion = UbicacionesBLL.Buscar(id);

                    if (ubicacion != null)
                    {
                        Estado = UbicacionesBLL.Modificar(LlenaClase());
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Estado)
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

            Ubicaciones ubicaciones = UbicacionesBLL.Buscar(id);

            if (ubicaciones != null)
            {
                if (UbicacionesBLL.Eliminar(id))
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
    }
}

    


  