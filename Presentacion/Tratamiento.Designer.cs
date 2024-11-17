namespace Presentacion
{
    partial class Tratamiento
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
            label3 = new Label();
            txtCosto = new TextBox();
            label5 = new Label();
            txtDescripcion = new RichTextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            dgvTratamientos = new DataGridView();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 23);
            label1.Name = "label1";
            label1.Size = new Size(174, 34);
            label1.TabIndex = 0;
            label1.Text = "Tratamiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(78, 152);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 1;
            label3.Text = "Costo:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(145, 149);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(200, 27);
            txtCosto.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(383, 96);
            label5.Name = "label5";
            label5.Size = new Size(112, 19);
            label5.TabIndex = 1;
            label5.Text = "Descripcion:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(497, 96);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(318, 80);
            txtDescripcion.TabIndex = 3;
            txtDescripcion.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(58, 96);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 2;
            // 
            // dgvTratamientos
            // 
            dgvTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTratamientos.BackgroundColor = SystemColors.ButtonFace;
            dgvTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTratamientos.Dock = DockStyle.Bottom;
            dgvTratamientos.Location = new Point(0, 284);
            dgvTratamientos.Name = "dgvTratamientos";
            dgvTratamientos.RowHeadersWidth = 51;
            dgvTratamientos.RowTemplate.Height = 29;
            dgvTratamientos.Size = new Size(919, 280);
            dgvTratamientos.TabIndex = 4;
            dgvTratamientos.CellClick += dgvTratamientos_CellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 124, 170);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(230, 206);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(0, 124, 170);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.Control;
            btnEditar.Location = new Point(365, 206);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(0, 124, 170);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(497, 206);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Tratamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(919, 564);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvTratamientos);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(txtCosto);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tratamiento";
            Text = "Tratamiento";
            Load += Tratamiento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTratamientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtCosto;
        private Label label5;
        private RichTextBox txtDescripcion;
        private Label label2;
        private TextBox txtNombre;
        private DataGridView dgvTratamientos;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}