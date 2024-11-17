namespace Presentacion
{
    partial class Historial_Clinico
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
            dgvHistorial = new DataGridView();
            label1 = new Label();
            txtDescripcion = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            txtTratamiento = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            btnFinalizado = new Button();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Dock = DockStyle.Bottom;
            dgvHistorial.Location = new Point(0, 284);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 29;
            dgvHistorial.Size = new Size(919, 280);
            dgvHistorial.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(374, 18);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 1;
            label1.Text = "Historial Clinico";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(484, 59);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(407, 128);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(366, 62);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 3;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(7, 139);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 4;
            label3.Text = "Tratamiento";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(144, 136);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(192, 27);
            txtTratamiento.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 27);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(34, 62);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 7;
            label4.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Gainsboro;
            btnGuardar.Location = new Point(200, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnFinalizado
            // 
            btnFinalizado.BackColor = Color.Green;
            btnFinalizado.FlatAppearance.BorderSize = 0;
            btnFinalizado.FlatStyle = FlatStyle.Flat;
            btnFinalizado.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalizado.ForeColor = Color.Gainsboro;
            btnFinalizado.Location = new Point(549, 217);
            btnFinalizado.Name = "btnFinalizado";
            btnFinalizado.Size = new Size(250, 30);
            btnFinalizado.TabIndex = 9;
            btnFinalizado.Text = "Tratamiento Completado";
            btnFinalizado.UseVisualStyleBackColor = false;
            btnFinalizado.Click += btnFinalizado_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrar.ForeColor = Color.Gainsboro;
            btnFiltrar.Location = new Point(335, 249);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(200, 30);
            btnFiltrar.TabIndex = 11;
            btnFiltrar.Text = "Filtrar por Nombre";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // Historial_Clinico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(919, 564);
            Controls.Add(btnFiltrar);
            Controls.Add(btnFinalizado);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(txtTratamiento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(dgvHistorial);
            Name = "Historial_Clinico";
            Text = "Historial_Clinico";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistorial;
        private Label label1;
        private RichTextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private TextBox txtTratamiento;
        private TextBox txtNombre;
        private Label label4;
        private Button btnGuardar;
        private Button btnFinalizado;
        private Button btnFiltrar;
    }
}