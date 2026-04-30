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
    public partial class FormCostoReceta : Form
    {
        public FormCostoReceta()
        {
            InitializeComponent();
        }

        private void FormCostoReceta_Load(object sender, EventArgs e)
        {
            CargarRecetas();
           // MessageBox.Show("Cargando recetas...");
        }

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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstRecetas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una receta");
                return;
            }

            ComboItem receta = (ComboItem)lstRecetas.SelectedItem;
            int idReceta = receta.Valor;

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                // DETALLE
                string queryDetalle = @"SELECT 
                                i.nombre AS Ingrediente,
                                ri.cantidad,
                                i.precio,
                                (ri.cantidad * i.precio) AS Subtotal
                               FROM receta_ingrediente ri
                               JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
                               WHERE ri.id_receta = @receta";

                MySqlDataAdapter da = new MySqlDataAdapter(queryDetalle, conexion);
                da.SelectCommand.Parameters.AddWithValue("@receta", idReceta);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDetalle.DataSource = dt;

                // TOTAL
                string queryTotal = @"SELECT SUM(ri.cantidad * i.precio)
                             FROM receta_ingrediente ri
                             JOIN ingrediente i ON ri.id_ingrediente = i.id_ingrediente
                             WHERE ri.id_receta = @receta";

                MySqlCommand cmd = new MySqlCommand(queryTotal, conexion);
                cmd.Parameters.AddWithValue("@receta", idReceta);

                object resultado = cmd.ExecuteScalar();

                if (resultado != DBNull.Value)
                {
                    decimal total = Convert.ToDecimal(resultado);
                    lblTotal.Text = "Total: $" + total.ToString("0.00");
                }
                else
                {
                    lblTotal.Text = "Total: $0";
                }
            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
