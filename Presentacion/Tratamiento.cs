using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Tratamiento : Form
    {
        public Tratamiento()
        {
            InitializeComponent();
        }
        private void CargarTratamientos()
        {
            UserDao dao = new UserDao();
            DataTable tratamientos = dao.ObtenerTratamientos();
            dgvTratamientos.DataSource = tratamientos;
        }
        private void Tratamiento_Load(object sender, EventArgs e)
        {
            CargarTratamientos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal costo = Convert.ToDecimal(txtCosto.Text);

            UserDao dao = new UserDao();
            dao.AgregarTratamiento(nombre, descripcion, costo);

            CargarTratamientos(); // Refresca el DataGridView después de agregar
        }

        private void dgvTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTratamientos.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
                txtCosto.Text = row.Cells["costo"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTratamientos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvTratamientos.CurrentRow.Cells["id_tratamiento"].Value);
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;
                decimal costo = Convert.ToDecimal(txtCosto.Text);

                UserDao dao = new UserDao();
                dao.ActualizarTratamiento(id, nombre, descripcion, costo);

                CargarTratamientos(); // Refresca el DataGridView después de editar
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTratamientos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvTratamientos.CurrentRow.Cells["id_tratamiento"].Value);

                UserDao dao = new UserDao();
                dao.EliminarTratamiento(id);

                CargarTratamientos(); // Refresca el DataGridView después de eliminar
            }
        }
    }
}
