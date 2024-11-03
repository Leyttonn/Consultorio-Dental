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
            btnCerrar.Location = new Point(1172, 3);
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
            pictureBox2.Location = new Point(376, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 144);
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
            panelContenedor.Size = new Size(1200, 650);
            panelContenedor.TabIndex = 3;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = SystemColors.Control;
            panelFormularios.Controls.Add(pictureBox2);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(300, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(900, 610);
            panelFormularios.TabIndex = 8;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 124, 170);
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 610);
            panelMenu.TabIndex = 7;
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
            panel3.Size = new Size(300, 125);
            panel3.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.FromArgb(0, 100, 150);
            lblEmail.BorderStyle = BorderStyle.None;
            lblEmail.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(129, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(140, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblId
            // 
            lblId.BackColor = Color.FromArgb(0, 100, 150);
            lblId.BorderStyle = BorderStyle.None;
            lblId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(129, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(140, 19);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.FromArgb(0, 100, 150);
            lblNombre.BorderStyle = BorderStyle.None;
            lblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(129, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(140, 19);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(0, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(300, 50);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 650);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 650);
            Name = "Form1";
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
    }
}