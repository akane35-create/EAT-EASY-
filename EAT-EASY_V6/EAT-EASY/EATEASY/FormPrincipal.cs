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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            FormRecetas f = new FormRecetas();
            f.ShowDialog(); // 🔥 IMPORTANTE
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            FormIngredientes f = new FormIngredientes();
            f.ShowDialog();
        }

        private void btnRecetaIngredientes_Click(object sender, EventArgs e)
        {
            FormRecetaIngredientes f = new FormRecetaIngredientes();
            f.ShowDialog();
        }

        private void btnCostoReceta_Click(object sender, EventArgs e)
        {
            FormCostoReceta f = new FormCostoReceta();
            f.ShowDialog();
        }

        private void btnMenuSemanal_Click(object sender, EventArgs e)
        {
            FormMenuSemanal f = new FormMenuSemanal();
            f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
