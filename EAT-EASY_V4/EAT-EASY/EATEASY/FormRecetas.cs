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
    public partial class FormRecetas : Form
    {
        public FormRecetas()
        {
            InitializeComponent();
        }

        private void CargarRecetas()
        {
            Conexion con = new Conexion();
            MySqlConnection conexion = con.ObtenerConexion();

            string query = "SELECT * FROM receta";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgvRecetas.DataSource = dt;

            conexion.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN CAMPOS VACÍOS
            if (txtNombre.Text == "" || txtPasos.Text == "" || txtTiempo.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            // VALIDACIÓN NUMÉRICA
            int tiempo;
            if (!int.TryParse(txtTiempo.Text, out tiempo))
            {
                MessageBox.Show("El tiempo debe ser un número");
                return;
            }

            try
            {
                Conexion con = new Conexion();
                MySqlConnection conexion = con.ObtenerConexion();

                // 🔹 VALIDAR QUE NO EXISTA
                string verificar = "SELECT COUNT(*) FROM receta WHERE nombre = @nombre";
                MySqlCommand cmdVerificar = new MySqlCommand(verificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@nombre", txtNombre.Text);

                int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("La receta ya existe");
                    conexion.Close();
                    return;
                }

                // 🔹 INSERT
                string query = "INSERT INTO receta(nombre, pasos, tiempo) VALUES(@nombre, @pasos, @tiempo)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@pasos", txtPasos.Text);
                cmd.Parameters.AddWithValue("@tiempo", tiempo);

                cmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Receta guardada correctamente");

                LimpiarCampos();
                CargarRecetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔹 4. LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPasos.Clear();
            txtTiempo.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
