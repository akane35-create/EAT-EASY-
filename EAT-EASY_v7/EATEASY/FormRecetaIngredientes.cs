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
    public partial class FormRecetaIngredientes : Form
    {
        public FormRecetaIngredientes()
        {
            InitializeComponent();
        }

        //LOAD
        private void FormRecetaIngredientes_Load(object sender, EventArgs e)
        {
            CargarRecetas();
            CargarIngredientes();
            CargarDetalle();
        }

        // CARGAR RECETAS
        private void CargarRecetas()
        {
            lstRecetas.Items.Clear();

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string query = "SELECT id_receta, nombre FROM receta";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lstRecetas.Items.Add(new ComboItem
                    {
                        Texto = dr["nombre"].ToString(),
                        Valor = Convert.ToInt32(dr["id_receta"])
                    });
                }
            }
        }

        // CARGAR INGREDIENTES
        private void CargarIngredientes()
        {
            lstIngredientes.Items.Clear();

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string query = "SELECT id_ingrediente, nombre FROM ingrediente";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lstIngredientes.Items.Add(new ComboItem
                    {
                        Texto = dr["nombre"].ToString(),
                        Valor = Convert.ToInt32(dr["id_ingrediente"])
                    });
                }
            }
        }

        // CARGAR TABLA
        private void CargarDetalle()
        {
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string query = @"SELECT r.nombre AS Receta,
                                        i.nombre AS Ingrediente,
                                        ri.cantidad
                                 FROM receta_ingrediente ri
                                 JOIN receta r ON ri.id_receta = r.id_receta
                                 JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvDetalle.DataSource = dt;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
               {
            // Validaciones
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese cantidad");
                return;
            }

            decimal cantidad;

            if (!decimal.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            if (lstRecetas.SelectedItem == null || lstIngredientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una receta y un ingrediente");
                return;
            }

            ComboItem receta = (ComboItem)lstRecetas.SelectedItem;
            ComboItem ingrediente = (ComboItem)lstIngredientes.SelectedItem;

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string query = @"INSERT INTO receta_ingrediente(id_receta, id_ingrediente, cantidad)
                                 VALUES(@receta, @ingrediente, @cantidad)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@receta", receta.Valor);
                cmd.Parameters.AddWithValue("@ingrediente", ingrediente.Valor);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Guardado correctamente");

            txtCantidad.Clear();
            CargarDetalle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRecetaIngredientes f = new FormRecetaIngredientes();
            f.ShowDialog();

            this.Close(); // cierra el menú
        }
    }
}