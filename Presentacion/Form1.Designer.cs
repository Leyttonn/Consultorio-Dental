namespace Presentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogout = new Button();
            panel3 = new Panel();
            lblEmail = new TextBox();
            lblNombre = new TextBox();
            lblId = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(975, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(944, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnMinimizar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 40);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 120, 170);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 560);
            panel2.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(0, 510);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(300, 50);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 100, 150);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(lblNombre);
            panel3.Controls.Add(lblId);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 125);
            panel3.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.FromArgb(0, 100, 150);
            lblEmail.BorderStyle = BorderStyle.None;
            lblEmail.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(102, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(125, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.FromArgb(0, 100, 150);
            lblNombre.BorderStyle = BorderStyle.None;
            lblNombre.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(102, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(125, 19);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.BackColor = Color.FromArgb(0, 100, 150);
            lblId.BorderStyle = BorderStyle.None;
            lblId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(102, 21);
            lblId.Name = "lblId";
            lblId.Size = new Size(125, 19);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(540, 234);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Panel panel1;
        private Panel panel2;
        private Button btnLogout;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox lblId;
        private TextBox lblEmail;
        private TextBox lblNombre;
    }
}