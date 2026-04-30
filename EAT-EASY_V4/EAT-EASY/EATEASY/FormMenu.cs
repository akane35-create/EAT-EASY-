using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EATEASY
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            FormRecetas frm = new FormRecetas();
            frm.Show();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            FormIngredientes frm = new FormIngredientes();
            frm.Show();
        }

        private void btnRelacion_Click(object sender, EventArgs e)
        {
            FormRecetaIngredientes frm = new FormRecetaIngredientes();
            frm.Show();
        }

        private void btnCosto_Click(object sender, EventArgs e)
        {
            FormCostoReceta frm = new FormCostoReceta();
            frm.Show();
        }
    }
}
