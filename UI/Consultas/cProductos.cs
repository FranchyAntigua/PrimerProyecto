using PrimerProyecto.BLL;
using PrimerProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto.UI.Consultas
{
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Productos, bool>> filtro = g => true;
            ProductoDdataGridView.DataSource = ProductosBLL.GetList(filtro);
        }
    }
}
