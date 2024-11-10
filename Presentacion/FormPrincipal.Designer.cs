namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            pictureBox2 = new PictureBox();
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            panelMenu = new Panel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            btnTratamiento = new Button();
            btnPaciente = new Button();
            panel3 = new Panel();
            lblEmail = new TextBox();
            pictureBox1 = new PictureBox();
            lblId = new TextBox();
            lblNombre = new TextBox();
            btnLogout = new Button();
            panelBarraTitulo = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContenedor.SuspendLayout();
            panelFormularios.SuspendLayout();
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBarraTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1173, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1142, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(379, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 212);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1200, 651);
            panelContenedor.TabIndex = 3;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = SystemColors.Control;
            panelFormularios.Controls.Add(pictureBox2);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(263, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(937, 611);
            panelFormularios.TabIndex = 8;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 124, 170);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnTratamiento);
            panelMenu.Controls.Add(btnPaciente);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(263, 611);
            panelMenu.TabIndex = 7;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(0, 390);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(263, 53);
            button4.TabIndex = 9;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Gainsboro;
            button5.Location = new Point(0, 337);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(263, 53);
            button5.TabIndex = 10;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Gainsboro;
            button6.Location = new Point(0, 284);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(263, 53);
            button6.TabIndex = 11;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 231);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(263, 53);
            button3.TabIndex = 4;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnTratamiento
            // 
            btnTratamiento.Dock = DockStyle.Top;
            btnTratamiento.FlatAppearance.BorderSize = 0;
            btnTratamiento.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnTratamiento.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnTratamiento.FlatStyle = FlatStyle.Flat;
            btnTratamiento.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTratamiento.ForeColor = Color.Gainsboro;
            btnTratamiento.Location = new Point(0, 178);
            btnTratamiento.Margin = new Padding(3, 4, 3, 4);
            btnTratamiento.Name = "btnTratamiento";
            btnTratamiento.Size = new Size(263, 53);
            btnTratamiento.TabIndex = 4;
            btnTratamiento.Text = "Tratamiento";
            btnTratamiento.UseVisualStyleBackColor = true;
            btnTratamiento.Click += btnTratamiento_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.Dock = DockStyle.Top;
            btnPaciente.FlatAppearance.BorderSize = 0;
            btnPaciente.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnPaciente.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnPaciente.FlatStyle = FlatStyle.Flat;
            btnPaciente.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaciente.ForeColor = Color.Gainsboro;
            btnPaciente.Location = new Point(0, 125);
            btnPaciente.Margin = new Padding(3, 4, 3, 4);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(263, 53);
            btnPaciente.TabIndex = 4;
            btnPaciente.Text = "Paciente";
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 100, 150);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(lblId);
            panel3.Controls.Add(lblNombre);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 125);
            panel3.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.FromArgb(0, 100, 150);
            lblEmail.BorderStyle = BorderStyle.None;
            lblEmail.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(97, 84);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(154, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblId
            // 
            lblId.BackColor = Color.FromArgb(0, 100, 150);
            lblId.BorderStyle = BorderStyle.None;
            lblId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(97, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(154, 19);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.FromArgb(0, 100, 150);
            lblNombre.BorderStyle = BorderStyle.None;
            lblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(97, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(154, 19);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Gainsboro;
            btnLogout.Location = new Point(0, 558);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(263, 53);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = Color.FromArgb(0, 122, 204);
            panelBarraTitulo.Controls.Add(btnMinimizar);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(1200, 40);
            panelBarraTitulo.TabIndex = 6;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove_1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 651);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 651);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContenedor.ResumeLayout(false);
            panelFormularios.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox pictureBox2;
        private Panel panelContenedor;
        private Panel panelFormularios;
        private Panel panelMenu;
        private Panel panel3;
        private TextBox lblEmail;
        private PictureBox pictureBox1;
        private TextBox lblId;
        private TextBox lblNombre;
        private Button btnLogout;
        private Panel panelBarraTitulo;
        private Button button3;
        private Button btnTratamiento;
        private Button btnPaciente;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}