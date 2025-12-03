namespace Barber_Royal
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartCitas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblTotalClientes = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblTotalBarberos = new Label();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            lblCitasProgramadas = new Label();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            lblCitasCompletadas = new Label();
            dgvUltimasCitas = new DataGridView();
            lblReloj = new Label();
            calendarioDashboard = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)chartCitas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasCitas).BeginInit();
            SuspendLayout();
            // 
            // chartCitas
            // 
            chartCitas.BorderlineColor = Color.Black;
            chartArea1.Name = "ChartArea1";
            chartCitas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCitas.Legends.Add(legend1);
            chartCitas.Location = new Point(220, 12);
            chartCitas.Name = "chartCitas";
            chartCitas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCitas.Series.Add(series1);
            chartCitas.Size = new Size(501, 321);
            chartCitas.TabIndex = 0;
            chartCitas.Text = "chart1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTotalClientes);
            panel1.Location = new Point(756, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 109);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(229, 33);
            label2.Name = "label2";
            label2.Size = new Size(151, 50);
            label2.TabIndex = 4;
            label2.Text = "Clientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gente;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTotalClientes
            // 
            lblTotalClientes.Font = new Font("Segoe UI", 48F);
            lblTotalClientes.ForeColor = Color.Gold;
            lblTotalClientes.Location = new Point(421, 19);
            lblTotalClientes.Name = "lblTotalClientes";
            lblTotalClientes.Size = new Size(53, 78);
            lblTotalClientes.TabIndex = 0;
            lblTotalClientes.Text = "label1";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTotalBarberos);
            panel2.Location = new Point(756, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 112);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(213, 33);
            label1.Name = "label1";
            label1.Size = new Size(167, 50);
            label1.TabIndex = 3;
            label1.Text = "Barberos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.barbero_2;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(126, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblTotalBarberos
            // 
            lblTotalBarberos.Font = new Font("Segoe UI", 48F);
            lblTotalBarberos.ForeColor = Color.Gold;
            lblTotalBarberos.Location = new Point(421, 20);
            lblTotalBarberos.Name = "lblTotalBarberos";
            lblTotalBarberos.Size = new Size(61, 77);
            lblTotalBarberos.TabIndex = 1;
            lblTotalBarberos.Text = "label2";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(lblCitasProgramadas);
            panel3.Location = new Point(756, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 150);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(87, 9);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 4;
            label3.Text = "Citas Totales";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.peluquero;
            pictureBox3.Location = new Point(3, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblCitasProgramadas
            // 
            lblCitasProgramadas.Font = new Font("Segoe UI", 48F);
            lblCitasProgramadas.ForeColor = Color.Gold;
            lblCitasProgramadas.Location = new Point(229, 53);
            lblCitasProgramadas.Name = "lblCitasProgramadas";
            lblCitasProgramadas.Size = new Size(61, 77);
            lblCitasProgramadas.TabIndex = 0;
            lblCitasProgramadas.Text = "label3";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblCitasCompletadas);
            panel4.Location = new Point(756, 401);
            panel4.Name = "panel4";
            panel4.Size = new Size(322, 156);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(62, 3);
            label4.Name = "label4";
            label4.Size = new Size(211, 32);
            label4.TabIndex = 5;
            label4.Text = "Citas Completadas";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.confirmar;
            pictureBox4.Location = new Point(3, 44);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(126, 89);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // lblCitasCompletadas
            // 
            lblCitasCompletadas.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCitasCompletadas.ForeColor = Color.Gold;
            lblCitasCompletadas.Location = new Point(229, 44);
            lblCitasCompletadas.Name = "lblCitasCompletadas";
            lblCitasCompletadas.Size = new Size(55, 82);
            lblCitasCompletadas.TabIndex = 0;
            lblCitasCompletadas.Text = "label4";
            // 
            // dgvUltimasCitas
            // 
            dgvUltimasCitas.BackgroundColor = Color.Gray;
            dgvUltimasCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasCitas.GridColor = Color.Black;
            dgvUltimasCitas.Location = new Point(220, 353);
            dgvUltimasCitas.Name = "dgvUltimasCitas";
            dgvUltimasCitas.Size = new Size(501, 204);
            dgvUltimasCitas.TabIndex = 5;
            // 
            // lblReloj
            // 
            lblReloj.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReloj.ForeColor = Color.Gold;
            lblReloj.Location = new Point(1090, 422);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(192, 50);
            lblReloj.TabIndex = 6;
            lblReloj.Text = "label1";
            // 
            // calendarioDashboard
            // 
            calendarioDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendarioDashboard.Location = new Point(1090, 251);
            calendarioDashboard.Name = "calendarioDashboard";
            calendarioDashboard.TabIndex = 7;
            calendarioDashboard.TitleBackColor = Color.Gold;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1380, 580);
            Controls.Add(calendarioDashboard);
            Controls.Add(panel4);
            Controls.Add(lblReloj);
            Controls.Add(dgvUltimasCitas);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(chartCitas);
            ForeColor = Color.Gold;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chartCitas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCitas;
        private Panel panel1;
        private Label lblTotalClientes;
        private Panel panel2;
        private Label lblTotalBarberos;
        private Panel panel3;
        private Label lblCitasProgramadas;
        private Panel panel4;
        private Label lblCitasCompletadas;
        private DataGridView dgvUltimasCitas;
        private Label lblReloj;
        private MonthCalendar calendarioDashboard;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}