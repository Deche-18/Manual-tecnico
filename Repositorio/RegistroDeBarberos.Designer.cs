namespace Barber_Royal
{
    partial class RegistroDeBarberos
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
            dgvBarberos = new DataGridView();
            lbBarberos = new Label();
            lbNombreB = new Label();
            lbApellidoB = new Label();
            lbTelefonoB = new Label();
            lbEmailB = new Label();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtNombreB = new TextBox();
            txtApellidoB = new TextBox();
            txtTelefonoB = new TextBox();
            txtEmailB = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            btnBuscar = new Button();
            btnRefrescar = new Button();
            txtBuscadorBR = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBarberos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBarberos
            // 
            dgvBarberos.BackgroundColor = Color.DimGray;
            dgvBarberos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarberos.Location = new Point(577, 11);
            dgvBarberos.Margin = new Padding(3, 2, 3, 2);
            dgvBarberos.Name = "dgvBarberos";
            dgvBarberos.RowHeadersWidth = 51;
            dgvBarberos.Size = new Size(764, 255);
            dgvBarberos.TabIndex = 0;
            dgvBarberos.CellContentClick += dgvBarberos_CellContentClick;
            // 
            // lbBarberos
            // 
            lbBarberos.AutoSize = true;
            lbBarberos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBarberos.ForeColor = Color.Gold;
            lbBarberos.Location = new Point(41, 14);
            lbBarberos.Name = "lbBarberos";
            lbBarberos.Size = new Size(289, 37);
            lbBarberos.TabIndex = 1;
            lbBarberos.Text = "Registro De Barberos";
            // 
            // lbNombreB
            // 
            lbNombreB.AutoSize = true;
            lbNombreB.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombreB.ForeColor = SystemColors.MenuText;
            lbNombreB.Location = new Point(78, 82);
            lbNombreB.Name = "lbNombreB";
            lbNombreB.Size = new Size(59, 16);
            lbNombreB.TabIndex = 2;
            lbNombreB.Text = "Nombre:";
            // 
            // lbApellidoB
            // 
            lbApellidoB.AutoSize = true;
            lbApellidoB.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbApellidoB.ForeColor = SystemColors.MenuText;
            lbApellidoB.Location = new Point(78, 136);
            lbApellidoB.Name = "lbApellidoB";
            lbApellidoB.Size = new Size(60, 16);
            lbApellidoB.TabIndex = 3;
            lbApellidoB.Text = "Apellido:";
            // 
            // lbTelefonoB
            // 
            lbTelefonoB.AutoSize = true;
            lbTelefonoB.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbTelefonoB.ForeColor = SystemColors.MenuText;
            lbTelefonoB.Location = new Point(78, 187);
            lbTelefonoB.Name = "lbTelefonoB";
            lbTelefonoB.Size = new Size(64, 16);
            lbTelefonoB.TabIndex = 4;
            lbTelefonoB.Text = "Telefono:";
            // 
            // lbEmailB
            // 
            lbEmailB.AutoSize = true;
            lbEmailB.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbEmailB.ForeColor = SystemColors.MenuText;
            lbEmailB.Location = new Point(78, 239);
            lbEmailB.Name = "lbEmailB";
            lbEmailB.Size = new Size(44, 16);
            lbEmailB.TabIndex = 5;
            lbEmailB.Text = "Email:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Gold;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Transparent;
            btnAgregar.Location = new Point(78, 300);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(218, 42);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.Gold;
            btnEditar.FlatAppearance.BorderSize = 3;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.Gold;
            btnEditar.Location = new Point(680, 270);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(97, 36);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.Gold;
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Gold;
            btnEliminar.Location = new Point(577, 271);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 36);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombreB
            // 
            txtNombreB.BackColor = SystemColors.ScrollBar;
            txtNombreB.BorderStyle = BorderStyle.None;
            txtNombreB.Font = new Font("Microsoft Sans Serif", 12F);
            txtNombreB.Location = new Point(78, 100);
            txtNombreB.Margin = new Padding(3, 2, 3, 2);
            txtNombreB.Multiline = true;
            txtNombreB.Name = "txtNombreB";
            txtNombreB.Size = new Size(181, 23);
            txtNombreB.TabIndex = 9;
            txtNombreB.TextChanged += txtNombreB_TextChanged;
            // 
            // txtApellidoB
            // 
            txtApellidoB.BackColor = SystemColors.ScrollBar;
            txtApellidoB.BorderStyle = BorderStyle.None;
            txtApellidoB.Font = new Font("Microsoft Sans Serif", 12F);
            txtApellidoB.Location = new Point(78, 154);
            txtApellidoB.Margin = new Padding(3, 2, 3, 2);
            txtApellidoB.Multiline = true;
            txtApellidoB.Name = "txtApellidoB";
            txtApellidoB.Size = new Size(181, 23);
            txtApellidoB.TabIndex = 10;
            txtApellidoB.TextChanged += txtApellidoB_TextChanged;
            // 
            // txtTelefonoB
            // 
            txtTelefonoB.BackColor = SystemColors.ScrollBar;
            txtTelefonoB.BorderStyle = BorderStyle.None;
            txtTelefonoB.Font = new Font("Microsoft Sans Serif", 12F);
            txtTelefonoB.Location = new Point(78, 205);
            txtTelefonoB.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoB.Multiline = true;
            txtTelefonoB.Name = "txtTelefonoB";
            txtTelefonoB.Size = new Size(124, 23);
            txtTelefonoB.TabIndex = 11;
            txtTelefonoB.TextChanged += txtTelefonoB_TextChanged;
            // 
            // txtEmailB
            // 
            txtEmailB.BackColor = SystemColors.ScrollBar;
            txtEmailB.BorderStyle = BorderStyle.None;
            txtEmailB.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmailB.Location = new Point(78, 257);
            txtEmailB.Margin = new Padding(3, 2, 3, 2);
            txtEmailB.Multiline = true;
            txtEmailB.Name = "txtEmailB";
            txtEmailB.Size = new Size(181, 23);
            txtEmailB.TabIndex = 12;
            txtEmailB.TextChanged += txtEmailB_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbBarberos);
            panel1.Controls.Add(txtEmailB);
            panel1.Controls.Add(txtNombreB);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtTelefonoB);
            panel1.Controls.Add(lbEmailB);
            panel1.Controls.Add(txtApellidoB);
            panel1.Controls.Add(lbTelefonoB);
            panel1.Controls.Add(lbNombreB);
            panel1.Controls.Add(lbApellidoB);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F);
            panel1.Location = new Point(166, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 551);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Gold;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(78, 347);
            button1.Name = "button1";
            button1.Size = new Size(218, 42);
            button1.TabIndex = 13;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Black;
            btnBuscar.FlatAppearance.BorderSize = 3;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Gold;
            btnBuscar.Location = new Point(1278, 272);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 28);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Black;
            btnRefrescar.FlatAppearance.BorderSize = 3;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.Gold;
            btnRefrescar.Location = new Point(1006, 304);
            btnRefrescar.Margin = new Padding(3, 2, 3, 2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(78, 28);
            btnRefrescar.TabIndex = 15;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // txtBuscadorBR
            // 
            txtBuscadorBR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscadorBR.Location = new Point(1006, 271);
            txtBuscadorBR.Margin = new Padding(3, 2, 3, 2);
            txtBuscadorBR.Name = "txtBuscadorBR";
            txtBuscadorBR.Size = new Size(266, 29);
            txtBuscadorBR.TabIndex = 16;
            txtBuscadorBR.TextAlign = HorizontalAlignment.Center;
            // 
            // RegistroDeBarberos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1380, 580);
            Controls.Add(txtBuscadorBR);
            Controls.Add(btnRefrescar);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Controls.Add(btnEditar);
            Controls.Add(dgvBarberos);
            Controls.Add(btnEliminar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroDeBarberos";
            Text = "RegistroDeBarberos";
            Load += RegistroDeBarberos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarberos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBarberos;
        private Label lbBarberos;
        private Label lbNombreB;
        private Label lbApellidoB;
        private Label lbTelefonoB;
        private Label lbEmailB;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtNombreB;
        private TextBox txtApellidoB;
        private TextBox txtTelefonoB;
        private TextBox txtEmailB;
        private Panel panel1;
        private Button button1;
        private Button btnBuscar;
        private Button btnRefrescar;
        private TextBox txtBuscadorBR;
    }
}