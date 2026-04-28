using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EATEASY
{
    public partial class FormIngredientes : Form
    {
        public FormIngredientes()
        {
            InitializeComponent();
        }

        private void CargarIngredientes()
        {
            Conexion con = new Conexion();
            MySqlConnection conexion = con.ObtenerConexion();

            string query  = "SELECT * FROM ingrediente";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgvIngredientes.DataSource = dt;

            conexion.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // VALIDAR CAMPOS
            if (txtNombre.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido");
                return;
            }

            try
            {
                Conexion con = new Conexion();
                MySqlConnection conexion = con.ObtenerConexion();

                // 🔴 VALIDAR DUPLICADO
                string verificar = "SELECT COUNT(*) FROM ingrediente WHERE nombre = @nombre";
                MySqlCommand cmdVerificar = new MySqlCommand(verificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@nombre", txtNombre.Text);

                int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("El ingrediente ya existe");
                    conexion.Close();
                    return;
                }

                // 🔹 INSERT
                string query = "INSERT INTO ingrediente(nombre, precio) VALUES(@nombre, @precio)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@precio", precio);

                cmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Ingrediente guardado correctamente");

                LimpiarCampos();
                CargarIngredientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔹 LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
