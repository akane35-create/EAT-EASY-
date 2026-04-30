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
    public partial class FormMenuSemanal : Form
    {
        //VARIABLE GLOBAL
        int idMenuActual = 0;

        public FormMenuSemanal()
        {
            InitializeComponent();
        }

        // LOAD
        private void FormMenuSemanal_Load(object sender, EventArgs e)
        {
            CargarDias();
            CargarRecetas();
            CargarMenus();
        }

        private void cbMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenus.SelectedItem == null) return;

            ComboItem menu = (ComboItem)cbMenus.SelectedItem;

            idMenuActual = menu.Valor;

            CargarMenu();
        }

        // 🔹 CARGAR DÍAS
        private void CargarDias()
        {
            cbDia.Items.Clear();

            cbDia.Items.Add("Lunes");
            cbDia.Items.Add("Martes");
            cbDia.Items.Add("Miércoles");
            cbDia.Items.Add("Jueves");
            cbDia.Items.Add("Viernes");
            cbDia.Items.Add("Sábado");
            cbDia.Items.Add("Domingo");

            cbDia.SelectedIndex = 0;
        }

        // 🔹 CARGAR RECETAS
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

        private void CargarMenus()
        {
            cbMenus.Items.Clear();

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string query = "SELECT id_menu, fecha_creacion FROM menu_semanal";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbMenus.Items.Add(new ComboItem
                    {
                        Texto = dr["fecha_creacion"].ToString(),
                        Valor = Convert.ToInt32(dr["id_menu"])
                    });
                }
            }
        }

        // BOTÓN NUEVO MENÚ
        private void btnNuevoMenu_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string query = "INSERT INTO menu_semanal(fecha_creacion) VALUES (CURDATE())";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();

                idMenuActual = (int)cmd.LastInsertedId;
            }

            MessageBox.Show("Menú semanal creado");
            dgvMenu.DataSource = null; // limpiar tabla
        }

        // BOTÓN ASIGNAR RECETA
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (idMenuActual == 0)
            {
                MessageBox.Show("Primero crea un menú");
                return;
            }

            if (lstRecetas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una receta");
                return;
            }

            string dia = cbDia.SelectedItem.ToString();
            ComboItem receta = (ComboItem)lstRecetas.SelectedItem;

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                // VALIDAR QUE NO SE REPITA EL DÍA
                string verificar = @"SELECT COUNT(*) FROM menu_receta 
                                     WHERE id_menu = @menu AND dia_semana = @dia";

                MySqlCommand cmdVerificar = new MySqlCommand(verificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@menu", idMenuActual);
                cmdVerificar.Parameters.AddWithValue("@dia", dia);

                int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("Ese día ya tiene receta");
                    return;
                }

                // 🔹 INSERT
                string query = @"INSERT INTO menu_receta(id_menu, id_receta, dia_semana)
                                 VALUES(@menu, @receta, @dia)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@menu", idMenuActual);
                cmd.Parameters.AddWithValue("@receta", receta.Valor);
                cmd.Parameters.AddWithValue("@dia", dia);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Receta asignada");
            CargarMenu();
        }

        //  MOSTRAR MENÚ
        private void CargarMenu()
        {
            if (idMenuActual == 0) return;

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                string query = @"SELECT mr.dia_semana AS Día, r.nombre AS Receta
                                 FROM menu_receta mr
                                 JOIN receta r ON mr.id_receta = r.id_receta
                                 WHERE mr.id_menu = @menu
                                 ORDER BY FIELD(mr.dia_semana, 
                                 'Lunes','Martes','Miércoles','Jueves','Viernes','Sábado','Domingo')";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                da.SelectCommand.Parameters.AddWithValue("@menu", idMenuActual);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenu.DataSource = dt;
            }
        }
    }
}
