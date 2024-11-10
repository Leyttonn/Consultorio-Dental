namespace Presentacion
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtDate = new DateTimePicker();
            btnGuardar = new Button();
            dgvPaciente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Fecha_Nacimiento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(376, 20);
            label1.Name = "label1";
            label1.Size = new Size(135, 34);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(67, 96);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(67, 146);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 0;
            label3.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(178, 143);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(335, 99);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 0;
            label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(446, 96);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(335, 149);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(446, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(643, 104);
            label6.Name = "label6";
            label6.Size = new Size(192, 19);
            label6.TabIndex = 0;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(615, 144);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(276, 27);
            txtDate.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(237, 199);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dgvPaciente
            // 
            dgvPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaciente.BackgroundColor = SystemColors.ButtonFace;
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Apellido, Fecha_Nacimiento, Telefono, Email });
            dgvPaciente.Dock = DockStyle.Bottom;
            dgvPaciente.Location = new Point(0, 288);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.RowHeadersWidth = 51;
            dgvPaciente.RowTemplate.Height = 29;
            dgvPaciente.Size = new Size(919, 276);
            dgvPaciente.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            // 
            // Fecha_Nacimiento
            // 
            Fecha_Nacimiento.HeaderText = "Fecha_Nac";
            Fecha_Nacimiento.MinimumWidth = 6;
            Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(919, 564);
            Controls.Add(dgvPaciente);
            Controls.Add(btnGuardar);
            Controls.Add(txtDate);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Paciente";
            Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private DateTimePicker txtDate;
        private Button btnGuardar;
        private DataGridView dgvPaciente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Fecha_Nacimiento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
    }
}