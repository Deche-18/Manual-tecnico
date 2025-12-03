namespace Barber_Royal
{
    partial class RegistroDeClientescs
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
            lblRegsitroClientes = new Label();
            lbNombre = new Label();
            lbNacimiento = new Label();
            lbTelefono = new Label();
            lbApellido = new Label();
            lbEmail = new Label();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            dgvClientes = new DataGridView();
            txtNombreC = new TextBox();
            txtTelefonoC = new TextBox();
            txtApellidoC = new TextBox();
            txtEmailC = new TextBox();
            dtpNacimientoC = new DateTimePicker();
            btnLimpiar = new Button();
            panel1 = new Panel();
            txtBuscadorCLT = new TextBox();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegsitroClientes
            // 
            lblRegsitroClientes.AutoSize = true;
            lblRegsitroClientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegsitroClientes.ForeColor = Color.Gold;
            lblRegsitroClientes.Location = new Point(50, 21);
            lblRegsitroClientes.Name = "lblRegsitroClientes";
            lblRegsitroClientes.Size = new Size(273, 37);
            lblRegsitroClientes.TabIndex = 0;
            lblRegsitroClientes.Text = "Registro de Clientes";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 9.75F);
            lbNombre.ForeColor = SystemColors.ActiveCaptionText;
            lbNombre.Location = new Point(76, 67);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(60, 17);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre:";
            // 
            // lbNacimiento
            // 
            lbNacimiento.AutoSize = true;
            lbNacimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNacimiento.ForeColor = SystemColors.ActiveCaptionText;
            lbNacimiento.Location = new Point(75, 257);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(133, 17);
            lbNacimiento.TabIndex = 2;
            lbNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Segoe UI", 9.75F);
            lbTelefono.ForeColor = SystemColors.ActiveCaptionText;
            lbTelefono.Location = new Point(75, 162);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(61, 17);
            lbTelefono.TabIndex = 3;
            lbTelefono.Text = "Telefono:";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Font = new Font("Segoe UI", 9.75F);
            lbApellido.ForeColor = SystemColors.ActiveCaptionText;
            lbApellido.Location = new Point(76, 115);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(59, 17);
            lbApellido.TabIndex = 4;
            lbApellido.Text = "Apellido:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 9.75F);
            lbEmail.ForeColor = SystemColors.ActiveCaptionText;
            lbEmail.Location = new Point(76, 206);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(42, 17);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Gold;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ButtonFace;
            btnRegistrar.Location = new Point(76, 315);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(218, 42);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.FlatAppearance.BorderColor = Color.Gold;
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Gold;
            btnEliminar.Location = new Point(516, 349);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 36);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderColor = Color.Gold;
            btnEditar.FlatAppearance.BorderSize = 3;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Gold;
            btnEditar.Location = new Point(604, 349);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 36);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.DimGray;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(516, 11);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(837, 334);
            dgvClientes.TabIndex = 9;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // txtNombreC
            // 
            txtNombreC.BackColor = SystemColors.ScrollBar;
            txtNombreC.BorderStyle = BorderStyle.None;
            txtNombreC.Font = new Font("Microsoft Sans Serif", 12F);
            txtNombreC.Location = new Point(76, 84);
            txtNombreC.Margin = new Padding(3, 2, 3, 2);
            txtNombreC.Multiline = true;
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(181, 23);
            txtNombreC.TabIndex = 10;
            txtNombreC.TextChanged += txtNombreC_TextChanged;
            // 
            // txtTelefonoC
            // 
            txtTelefonoC.BackColor = SystemColors.ScrollBar;
            txtTelefonoC.BorderStyle = BorderStyle.None;
            txtTelefonoC.Font = new Font("Microsoft Sans Serif", 12F);
            txtTelefonoC.Location = new Point(76, 179);
            txtTelefonoC.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoC.Multiline = true;
            txtTelefonoC.Name = "txtTelefonoC";
            txtTelefonoC.Size = new Size(143, 25);
            txtTelefonoC.TabIndex = 12;
            txtTelefonoC.TextChanged += txtTelefonoC_TextChanged;
            // 
            // txtApellidoC
            // 
            txtApellidoC.BackColor = SystemColors.ScrollBar;
            txtApellidoC.BorderStyle = BorderStyle.None;
            txtApellidoC.Font = new Font("Microsoft Sans Serif", 12F);
            txtApellidoC.Location = new Point(76, 132);
            txtApellidoC.Margin = new Padding(3, 2, 3, 2);
            txtApellidoC.Multiline = true;
            txtApellidoC.Name = "txtApellidoC";
            txtApellidoC.Size = new Size(181, 23);
            txtApellidoC.TabIndex = 13;
            txtApellidoC.TextChanged += txtApellidoC_TextChanged;
            // 
            // txtEmailC
            // 
            txtEmailC.BackColor = SystemColors.ScrollBar;
            txtEmailC.BorderStyle = BorderStyle.None;
            txtEmailC.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmailC.Location = new Point(75, 223);
            txtEmailC.Margin = new Padding(3, 2, 3, 2);
            txtEmailC.Multiline = true;
            txtEmailC.Name = "txtEmailC";
            txtEmailC.Size = new Size(182, 23);
            txtEmailC.TabIndex = 14;
            txtEmailC.TextChanged += txtEmailC_TextChanged;
            // 
            // dtpNacimientoC
            // 
            dtpNacimientoC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNacimientoC.Location = new Point(75, 274);
            dtpNacimientoC.Margin = new Padding(3, 2, 3, 2);
            dtpNacimientoC.Name = "dtpNacimientoC";
            dtpNacimientoC.Size = new Size(273, 29);
            dtpNacimientoC.TabIndex = 15;
            dtpNacimientoC.ValueChanged += dtpNacimientoC_ValueChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderColor = Color.Gold;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Gold;
            btnLimpiar.Location = new Point(75, 361);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(219, 42);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(dtpNacimientoC);
            panel1.Controls.Add(txtEmailC);
            panel1.Controls.Add(txtApellidoC);
            panel1.Controls.Add(txtTelefonoC);
            panel1.Controls.Add(txtNombreC);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(lbApellido);
            panel1.Controls.Add(lbTelefono);
            panel1.Controls.Add(lbNacimiento);
            panel1.Controls.Add(lbNombre);
            panel1.Controls.Add(lblRegsitroClientes);
            panel1.Location = new Point(107, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 551);
            panel1.TabIndex = 17;
            // 
            // txtBuscadorCLT
            // 
            txtBuscadorCLT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscadorCLT.Location = new Point(1035, 349);
            txtBuscadorCLT.Margin = new Padding(3, 2, 3, 2);
            txtBuscadorCLT.Name = "txtBuscadorCLT";
            txtBuscadorCLT.Size = new Size(242, 29);
            txtBuscadorCLT.TabIndex = 18;
            txtBuscadorCLT.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.FlatAppearance.BorderSize = 3;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Gold;
            btnBuscar.Location = new Point(1283, 349);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(70, 29);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Black;
            btnRefrescar.FlatAppearance.BorderSize = 3;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.ForeColor = Color.Gold;
            btnRefrescar.Location = new Point(1035, 382);
            btnRefrescar.Margin = new Padding(3, 2, 3, 2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(79, 29);
            btnRefrescar.TabIndex = 20;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // RegistroDeClientescs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1380, 580);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscadorCLT);
            Controls.Add(panel1);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroDeClientescs";
            Text = "RegistroDeClientescs";
            Load += RegistroDeClientescs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegsitroClientes;
        private Label lbNombre;
        private Label lbNacimiento;
        private Label lbTelefono;
        private Label lbApellido;
        private Label lbEmail;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dgvClientes;
        private TextBox txtNombreC;
        private TextBox txtTelefonoC;
        private TextBox txtApellidoC;
        private TextBox txtEmailC;
        private DateTimePicker dtpNacimientoC;
        private Button btnLimpiar;
        private Panel panel1;
        private TextBox txtBuscadorCLT;
        private Button btnBuscar;
        private Button btnRefrescar;
    }
}