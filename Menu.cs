using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerProyecto.UI.Consultas;
using PrimerProyecto.UI.Registros;

namespace PrimerProyecto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos rProductos = new rProductos();
            rProductos.Show();
        }

        private void ProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cProductos c = new cProductos();
            c.Show();
        }
    }
}
