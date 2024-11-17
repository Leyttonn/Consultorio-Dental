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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
            this.Load += new EventHandler(Paciente_Load);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = txtDate.Value;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;

            UserDao dao = new UserDao();
            dao.AgregarPaciente(nombre, apellido, fechaNacimiento, telefono, email);

            // Refresca el DataGridView después de agregar el paciente
            CargarPacientes();
        }



        private void CargarPacientes()
        {
            UserDao dao = new UserDao();
            DataTable pacientes = dao.ObtenerPacientes();
            dgvPaciente.DataSource = pacientes;
        }
        private void Paciente_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que haya una fila seleccionada
            {
                DataGridViewRow row = dgvPaciente.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtApellido.Text = row.Cells["apellido"].Value.ToString();
                txtDate.Value = Convert.ToDateTime(row.Cells["fecha_nacimiento"].Value);
                txtTelefono.Text = row.Cells["telefono"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPaciente.CurrentRow.Cells["id_paciente"].Value);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                DateTime fechaNacimiento = txtDate.Value;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;

                UserDao dao = new UserDao();
                dao.ActualizarPaciente(id, nombre, apellido, fechaNacimiento, telefono, email);

                CargarPacientes(); // Refresca el DataGridView después de editar
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaciente.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPaciente.CurrentRow.Cells["id_paciente"].Value);

                UserDao dao = new UserDao();
                dao.EliminarPaciente(id);

                CargarPacientes(); // Refresca el DataGridView después de eliminar
            }
        }
    }
}
