namespace Barber_Royal
{
    partial class Citas
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
            lbCliente = new Label();
            lbBarbero = new Label();
            lbServicio = new Label();
            lbFecha = new Label();
            lbHora = new Label();
            lbobservaciones = new Label();
            cmbCliente = new ComboBox();
            cmbBarbero = new ComboBox();
            dtpFecha = new DateTimePicker();
            dtpHora = new DateTimePicker();
            dataGridView1 = new DataGridView();
            lbRegistrarCitas = new Label();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            ckbCorte = new CheckBox();
            ckbBarba = new CheckBox();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            txtObservaciones = new TextBox();
            ckbColoracion = new CheckBox();
            ckbCejas = new CheckBox();
            ckbOtro = new CheckBox();
            panel1 = new Panel();
            dtpHoraFin = new DateTimePicker();
            btnFiltroCliente = new Button();
            txtbusquedaCLT = new TextBox();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Font = new Font("Microsoft JhengHei", 9.75F);
            lbCliente.ForeColor = SystemColors.MenuText;
            lbCliente.Location = new Point(70, 72);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(53, 17);
            lbCliente.TabIndex = 0;
            lbCliente.Text = "Cliente:";
            // 
            // lbBarbero
            // 
            lbBarbero.AutoSize = true;
            lbBarbero.Font = new Font("Microsoft JhengHei", 9.75F);
            lbBarbero.ForeColor = SystemColors.MenuText;
            lbBarbero.Location = new Point(70, 126);
            lbBarbero.Name = "lbBarbero";
            lbBarbero.Size = new Size(59, 17);
            lbBarbero.TabIndex = 1;
            lbBarbero.Text = "Barbero:";
            // 
            // lbServicio
            // 
            lbServicio.AutoSize = true;
            lbServicio.Font = new Font("Microsoft JhengHei", 9.75F);
            lbServicio.ForeColor = SystemColors.MenuText;
            lbServicio.Location = new Point(32, 371);
            lbServicio.Name = "lbServicio";
            lbServicio.Size = new Size(57, 17);
            lbServicio.TabIndex = 2;
            lbServicio.Text = "Servicio:";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Microsoft JhengHei", 9.75F);
            lbFecha.ForeColor = SystemColors.MenuText;
            lbFecha.Location = new Point(70, 176);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(46, 17);
            lbFecha.TabIndex = 3;
            lbFecha.Text = "Fecha:";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Microsoft JhengHei", 9.75F);
            lbHora.ForeColor = SystemColors.MenuText;
            lbHora.Location = new Point(70, 223);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(41, 17);
            lbHora.TabIndex = 4;
            lbHora.Text = "Hora:";
            // 
            // lbobservaciones
            // 
            lbobservaciones.AutoSize = true;
            lbobservaciones.Font = new Font("Microsoft JhengHei", 9.75F);
            lbobservaciones.ForeColor = SystemColors.MenuText;
            lbobservaciones.Location = new Point(70, 273);
            lbobservaciones.Name = "lbobservaciones";
            lbobservaciones.Size = new Size(100, 17);
            lbobservaciones.TabIndex = 5;
            lbobservaciones.Text = "Observaciones:";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Segoe UI", 12F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(70, 91);
            cmbCliente.Margin = new Padding(3, 2, 3, 2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(218, 29);
            cmbCliente.TabIndex = 6;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // cmbBarbero
            // 
            cmbBarbero.Font = new Font("Segoe UI", 12F);
            cmbBarbero.FormattingEnabled = true;
            cmbBarbero.Location = new Point(70, 145);
            cmbBarbero.Margin = new Padding(3, 2, 3, 2);
            cmbBarbero.Name = "cmbBarbero";
            cmbBarbero.Size = new Size(219, 29);
            cmbBarbero.TabIndex = 7;
            cmbBarbero.SelectedIndexChanged += cmbBarbero_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Location = new Point(70, 192);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(283, 29);
            dtpFecha.TabIndex = 8;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // dtpHora
            // 
            dtpHora.Font = new Font("Segoe UI", 12F);
            dtpHora.Location = new Point(70, 242);
            dtpHora.Margin = new Padding(3, 2, 3, 2);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(283, 29);
            dtpHora.TabIndex = 9;
            dtpHora.ValueChanged += dtpHora_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DimGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(403, 12);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(972, 221);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellValueChanged;
            // 
            // lbRegistrarCitas
            // 
            lbRegistrarCitas.AutoSize = true;
            lbRegistrarCitas.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRegistrarCitas.ForeColor = Color.Gold;
            lbRegistrarCitas.Location = new Point(86, 9);
            lbRegistrarCitas.Name = "lbRegistrarCitas";
            lbRegistrarCitas.Size = new Size(203, 40);
            lbRegistrarCitas.TabIndex = 13;
            lbRegistrarCitas.Text = "Registar Citas";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Gold;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(70, 420);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(218, 42);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.Gold;
            btnEliminar.FlatAppearance.BorderSize = 3;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Gold;
            btnEliminar.Location = new Point(403, 237);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 36);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ckbCorte
            // 
            ckbCorte.AutoSize = true;
            ckbCorte.Font = new Font("Microsoft JhengHei", 9.75F);
            ckbCorte.ForeColor = SystemColors.MenuText;
            ckbCorte.Location = new Point(162, 370);
            ckbCorte.Margin = new Padding(3, 2, 3, 2);
            ckbCorte.Name = "ckbCorte";
            ckbCorte.Size = new Size(108, 21);
            ckbCorte.TabIndex = 16;
            ckbCorte.Text = "Corte de Pelo";
            ckbCorte.UseVisualStyleBackColor = true;
            ckbCorte.CheckedChanged += ckbCorte_CheckedChanged;
            // 
            // ckbBarba
            // 
            ckbBarba.AutoSize = true;
            ckbBarba.Font = new Font("Microsoft JhengHei", 9.75F);
            ckbBarba.ForeColor = SystemColors.MenuText;
            ckbBarba.Location = new Point(95, 370);
            ckbBarba.Margin = new Padding(3, 2, 3, 2);
            ckbBarba.Name = "ckbBarba";
            ckbBarba.Size = new Size(62, 21);
            ckbBarba.TabIndex = 17;
            ckbBarba.Text = "Barba";
            ckbBarba.UseVisualStyleBackColor = true;
            ckbBarba.CheckedChanged += ckbBarba_CheckedChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderColor = Color.Gold;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Gold;
            btnLimpiar.Location = new Point(71, 466);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(218, 42);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatAppearance.BorderColor = Color.Gold;
            btnActualizar.FlatAppearance.BorderSize = 3;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.Gold;
            btnActualizar.Location = new Point(506, 237);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(108, 36);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 12F);
            txtObservaciones.Location = new Point(70, 292);
            txtObservaciones.Margin = new Padding(3, 2, 3, 2);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(251, 74);
            txtObservaciones.TabIndex = 20;
            // 
            // ckbColoracion
            // 
            ckbColoracion.AutoSize = true;
            ckbColoracion.Font = new Font("Microsoft JhengHei", 9.75F);
            ckbColoracion.ForeColor = SystemColors.MenuText;
            ckbColoracion.Location = new Point(160, 395);
            ckbColoracion.Margin = new Padding(3, 2, 3, 2);
            ckbColoracion.Name = "ckbColoracion";
            ckbColoracion.Size = new Size(92, 21);
            ckbColoracion.TabIndex = 21;
            ckbColoracion.Text = "Coloracion";
            ckbColoracion.UseVisualStyleBackColor = true;
            ckbColoracion.CheckedChanged += ckbColoracion_CheckedChanged;
            // 
            // ckbCejas
            // 
            ckbCejas.AutoSize = true;
            ckbCejas.Font = new Font("Microsoft JhengHei", 9.75F);
            ckbCejas.ForeColor = SystemColors.MenuText;
            ckbCejas.Location = new Point(95, 395);
            ckbCejas.Margin = new Padding(3, 2, 3, 2);
            ckbCejas.Name = "ckbCejas";
            ckbCejas.Size = new Size(59, 21);
            ckbCejas.TabIndex = 22;
            ckbCejas.Text = "Cejas";
            ckbCejas.UseVisualStyleBackColor = true;
            ckbCejas.CheckedChanged += ckbCejas_CheckedChanged;
            // 
            // ckbOtro
            // 
            ckbOtro.AutoSize = true;
            ckbOtro.Font = new Font("Microsoft JhengHei", 9.75F);
            ckbOtro.ForeColor = SystemColors.MenuText;
            ckbOtro.Location = new Point(258, 395);
            ckbOtro.Margin = new Padding(3, 2, 3, 2);
            ckbOtro.Name = "ckbOtro";
            ckbOtro.Size = new Size(56, 21);
            ckbOtro.TabIndex = 23;
            ckbOtro.Text = "Otro";
            ckbOtro.UseVisualStyleBackColor = true;
            ckbOtro.CheckedChanged += ckbOtro_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbRegistrarCitas);
            panel1.Controls.Add(ckbOtro);
            panel1.Controls.Add(cmbCliente);
            panel1.Controls.Add(ckbColoracion);
            panel1.Controls.Add(ckbCejas);
            panel1.Controls.Add(lbCliente);
            panel1.Controls.Add(ckbCorte);
            panel1.Controls.Add(cmbBarbero);
            panel1.Controls.Add(txtObservaciones);
            panel1.Controls.Add(ckbBarba);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(lbBarbero);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(lbFecha);
            panel1.Controls.Add(lbServicio);
            panel1.Controls.Add(dtpHora);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(lbHora);
            panel1.Controls.Add(lbobservaciones);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 551);
            panel1.TabIndex = 24;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Location = new Point(1156, 546);
            dtpHoraFin.Margin = new Padding(3, 2, 3, 2);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(219, 23);
            dtpHoraFin.TabIndex = 25;
            dtpHoraFin.ValueChanged += dtpHoraFin_ValueChanged;
            // 
            // btnFiltroCliente
            // 
            btnFiltroCliente.BackColor = Color.Black;
            btnFiltroCliente.FlatAppearance.BorderSize = 3;
            btnFiltroCliente.FlatStyle = FlatStyle.Flat;
            btnFiltroCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFiltroCliente.ForeColor = Color.Gold;
            btnFiltroCliente.Location = new Point(1312, 237);
            btnFiltroCliente.Margin = new Padding(3, 2, 3, 2);
            btnFiltroCliente.Name = "btnFiltroCliente";
            btnFiltroCliente.Size = new Size(63, 28);
            btnFiltroCliente.TabIndex = 27;
            btnFiltroCliente.Text = "Buscar";
            btnFiltroCliente.UseVisualStyleBackColor = false;
            btnFiltroCliente.Click += btnFiltroCliente_Click;
            // 
            // txtbusquedaCLT
            // 
            txtbusquedaCLT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbusquedaCLT.Location = new Point(1054, 237);
            txtbusquedaCLT.Margin = new Padding(3, 2, 3, 2);
            txtbusquedaCLT.Name = "txtbusquedaCLT";
            txtbusquedaCLT.Size = new Size(252, 29);
            txtbusquedaCLT.TabIndex = 28;
            txtbusquedaCLT.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Black;
            btnRefrescar.FlatAppearance.BorderSize = 3;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.Gold;
            btnRefrescar.Location = new Point(1054, 270);
            btnRefrescar.Margin = new Padding(3, 2, 3, 2);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(80, 28);
            btnRefrescar.TabIndex = 29;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1387, 580);
            Controls.Add(btnRefrescar);
            Controls.Add(txtbusquedaCLT);
            Controls.Add(btnFiltroCliente);
            Controls.Add(dtpHoraFin);
            Controls.Add(panel1);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Citas";
            Text = "Citas";
            Load += Citas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCliente;
        private Label lbBarbero;
        private Label lbServicio;
        private Label lbFecha;
        private Label lbHora;
        private Label lbobservaciones;
        private ComboBox cmbCliente;
        private ComboBox cmbBarbero;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHora;
        private DataGridView dataGridView1;
        private Label lbRegistrarCitas;
        private Button btnRegistrar;
        private Button btnEliminar;
        private CheckBox ckbCorte;
        private CheckBox ckbBarba;
        private Button btnLimpiar;
        private Button btnActualizar;
        private TextBox txtObservaciones;
        private CheckBox ckbColoracion;
        private CheckBox ckbCejas;
        private CheckBox ckbOtro;
        private Panel panel1;
        private DateTimePicker dtpHoraFin;
        private Button btnFiltroCliente;
        private TextBox txtbusquedaCLT;
        private Button btnRefrescar;
    }
}