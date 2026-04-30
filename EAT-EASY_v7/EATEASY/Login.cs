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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacta al administrador para recuperar tu contraseña",
                "Recuperación de contraseña",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Seguro que deseas salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            //  VALIDAR CAMPOS VACÍOS
            if (usuario == "" || password == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            if (usuario == "admin" && password == "1234")
            {
                FormPrincipal frm = new FormPrincipal("admin");
                frm.Show();
                this.Hide();
            }
            else if (usuario == "usuario" && password == "1234")
            {
                FormPrincipal frm = new FormPrincipal("usuario");
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
