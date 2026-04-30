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
        private string tipoUsuario;

        public FormPrincipal(string tipo)
        {
            InitializeComponent();
            tipoUsuario = tipo;
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            FormRecetas f = new FormRecetas();
            f.ShowDialog(); 
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == "usuario")
            {
                MessageBox.Show("No tienes permisos para acceder");
                return;
            }

            FormIngredientes frm = new FormIngredientes();
            frm.Show();
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
            Login frm = new Login();
            frm.Show();

            this.Close(); // cierra el menú
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (tipoUsuario == "usuario")
            {
                btnIngredientes.Enabled = false; //  bloquea acceso
            }
        }
    }
}
