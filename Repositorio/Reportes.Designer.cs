namespace Barber_Royal
{
    partial class Reportes
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
            cmbTipoReporte = new ComboBox();
            gbFiltros = new GroupBox();
            label6 = new Label();
            lblRegistro = new Label();
            label8 = new Label();
            btnExportarPDF = new Button();
            label1 = new Label();
            label7 = new Label();
            btnExportarExcel = new Button();
            label5 = new Label();
            txtBusqueda = new TextBox();
            label4 = new Label();
            cmbBarberoFiltro = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            dgvPreview = new DataGridView();
            gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Items.AddRange(new object[] { "Clientes", "Barberos", "Citas" });
            cmbTipoReporte.Location = new Point(173, 201);
            cmbTipoReporte.Margin = new Padding(3, 4, 3, 4);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(153, 28);
            cmbTipoReporte.TabIndex = 0;
            // 
            // gbFiltros
            // 
            gbFiltros.BackColor = Color.White;
            gbFiltros.Controls.Add(label6);
            gbFiltros.Controls.Add(lblRegistro);
            gbFiltros.Controls.Add(label8);
            gbFiltros.Controls.Add(btnExportarPDF);
            gbFiltros.Controls.Add(label1);
            gbFiltros.Controls.Add(label7);
            gbFiltros.Controls.Add(btnExportarExcel);
            gbFiltros.Controls.Add(cmbTipoReporte);
            gbFiltros.Controls.Add(label5);
            gbFiltros.Controls.Add(txtBusqueda);
            gbFiltros.Controls.Add(label4);
            gbFiltros.Controls.Add(cmbBarberoFiltro);
            gbFiltros.Controls.Add(label3);
            gbFiltros.Controls.Add(label2);
            gbFiltros.Controls.Add(dtpHasta);
            gbFiltros.Controls.Add(dtpDesde);
            gbFiltros.Location = new Point(39, 54);
            gbFiltros.Margin = new Padding(3, 4, 3, 4);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Padding = new Padding(3, 4, 3, 4);
            gbFiltros.Size = new Size(496, 629);
            gbFiltros.TabIndex = 1;
            gbFiltros.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(149, 50);
            label6.Name = "label6";
            label6.Size = new Size(192, 54);
            label6.TabIndex = 15;
            label6.Text = "Reportes";
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(202, 136);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(44, 20);
            lblRegistro.TabIndex = 12;
            lblRegistro.Text = "titulo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 421);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 14;
            label8.Text = "Exportar en:";
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.Transparent;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnExportarPDF.ForeColor = Color.Gold;
            btnExportarPDF.Location = new Point(81, 455);
            btnExportarPDF.Margin = new Padding(3, 4, 3, 4);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(135, 49);
            btnExportarPDF.TabIndex = 13;
            btnExportarPDF.Text = "PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 204);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 2;
            label1.Text = "Tipo de reporte:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 422);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 12;
            label7.Text = "Exportar en:";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.Transparent;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnExportarExcel.ForeColor = Color.Gold;
            btnExportarExcel.Location = new Point(270, 454);
            btnExportarExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(131, 50);
            btnExportarExcel.TabIndex = 11;
            btnExportarExcel.Text = "Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 354);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 8;
            label5.Text = "Busqueda (name):";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(173, 351);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(153, 27);
            txtBusqueda.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 318);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Barbero:";
            // 
            // cmbBarberoFiltro
            // 
            cmbBarberoFiltro.FormattingEnabled = true;
            cmbBarberoFiltro.Location = new Point(173, 315);
            cmbBarberoFiltro.Margin = new Padding(3, 4, 3, 4);
            cmbBarberoFiltro.Name = "cmbBarberoFiltro";
            cmbBarberoFiltro.Size = new Size(153, 28);
            cmbBarberoFiltro.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 281);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Final:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 242);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Inicio";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(173, 276);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(291, 27);
            dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(173, 237);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(291, 27);
            dtpDesde.TabIndex = 0;
            // 
            // dgvPreview
            // 
            dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreview.Location = new Point(578, 88);
            dgvPreview.Margin = new Padding(3, 4, 3, 4);
            dgvPreview.Name = "dgvPreview";
            dgvPreview.RowHeadersWidth = 51;
            dgvPreview.Size = new Size(975, 523);
            dgvPreview.TabIndex = 11;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1567, 721);
            Controls.Add(dgvPreview);
            Controls.Add(gbFiltros);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbTipoReporte;
        private GroupBox gbFiltros;
        private Label label4;
        private ComboBox cmbBarberoFiltro;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label label1;
        private Label label7;
        private Button btnExportarExcel;
        private Label label5;
        private TextBox txtBusqueda;
        private DataGridView dgvPreview;
        private Label label8;
        private Button btnExportarPDF;
        private Label lblRegistro;
        private Label label6;
    }
}