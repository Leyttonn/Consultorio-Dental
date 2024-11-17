using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Historial_Clinico : Form
    {
        public Historial_Clinico()
        {
            InitializeComponent();
        }

        private void CargarTratamientos()
        {
            int idHistorial = ObtenerIdHistorialSeleccionado(); // Implementa este método
            UserDao dao = new UserDao();
            DataTable tratamientos = dao.ObtenerTratamientosPorHistorial(idHistorial);
            dgvTratamientos.DataSource = tratamientos;
        }




        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizado_Click(object sender, EventArgs e)
        {

        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            UserDao dao = new UserDao();
            DataTable pacientesFiltrados = dao.FiltrarPacientesPorNombre(nombre);
            dgvHistorial.DataSource = pacientesFiltrados;
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idHistorial = ObtenerIdHistorialSeleccionado(); // Implementa este método para obtener el ID del historial
            int idTratamiento = ObtenerIdTratamientoSeleccionado(); // Implementa este método para obtener el ID del tratamiento

            UserDao dao = new UserDao();
            dao.AgregarTratamientoAHistorial(idHistorial, idTratamiento);

            MessageBox.Show("Tratamiento agregado correctamente.");
        }
    }
}
