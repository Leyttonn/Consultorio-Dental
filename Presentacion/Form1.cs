using Datos;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar la aplicacion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que quieres cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserData
        }
        private void LoadUserData()
        {
            lblId.Text = Convert.ToString(UserLoginCache.UsuarioID);
            lblNombre.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
            lblEmail.Text = UserLoginCache.Email;
        }
    }
}