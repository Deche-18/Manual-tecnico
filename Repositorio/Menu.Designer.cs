namespace Barber_Royal
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            BarraVertical = new Panel();
            Submenu = new Panel();
            button7 = new Button();
            panel8 = new Panel();
            button6 = new Button();
            Administracion = new Button();
            panel6 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel5 = new Panel();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            button4 = new Button();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            PanelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            BarraVertical.SuspendLayout();
            Submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.Transparent;
            BarraTitulo.BackgroundImage = Properties.Resources.BarberShopRoyal___BackGround__;
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1600, 35);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.Paint += BarraTitulo_Paint;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.remove_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            btnMinimizar.Location = new Point(1530, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 22);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.close_51dp_E3E3E3_FILL0_wght400_GRAD0_opsz48;
            btnCerrar.Location = new Point(1562, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 22);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // BarraVertical
            // 
            BarraVertical.BackColor = Color.Black;
            BarraVertical.BackgroundImage = Properties.Resources.baber;
            BarraVertical.Controls.Add(Submenu);
            BarraVertical.Controls.Add(Administracion);
            BarraVertical.Controls.Add(panel6);
            BarraVertical.Controls.Add(pictureBox7);
            BarraVertical.Controls.Add(pictureBox6);
            BarraVertical.Controls.Add(panel5);
            BarraVertical.Controls.Add(button5);
            BarraVertical.Controls.Add(pictureBox5);
            BarraVertical.Controls.Add(panel4);
            BarraVertical.Controls.Add(button4);
            BarraVertical.Controls.Add(pictureBox4);
            BarraVertical.Controls.Add(panel3);
            BarraVertical.Controls.Add(button3);
            BarraVertical.Controls.Add(pictureBox3);
            BarraVertical.Controls.Add(panel2);
            BarraVertical.Controls.Add(button2);
            BarraVertical.Controls.Add(pictureBox2);
            BarraVertical.Controls.Add(panel1);
            BarraVertical.Controls.Add(button1);
            BarraVertical.Controls.Add(pictureBox1);
            BarraVertical.Dock = DockStyle.Left;
            BarraVertical.Location = new Point(0, 35);
            BarraVertical.Name = "BarraVertical";
            BarraVertical.Size = new Size(220, 580);
            BarraVertical.TabIndex = 1;
            // 
            // Submenu
            // 
            Submenu.BackColor = Color.Transparent;
            Submenu.Controls.Add(button7);
            Submenu.Controls.Add(panel8);
            Submenu.Controls.Add(button6);
            Submenu.Location = new Point(40, 378);
            Submenu.Name = "Submenu";
            Submenu.Size = new Size(180, 100);
            Submenu.TabIndex = 0;
            Submenu.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.Gold;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLight;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 34);
            button7.Name = "button7";
            button7.Size = new Size(181, 29);
            button7.TabIndex = 14;
            button7.Text = "Reportes";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gold;
            panel8.Location = new Point(-8, 27);
            panel8.Name = "panel8";
            panel8.Size = new Size(5, 46);
            panel8.TabIndex = 13;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.Gold;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLight;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(180, 29);
            button6.TabIndex = 12;
            button6.Text = "Back up";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Administracion
            // 
            Administracion.BackColor = Color.Transparent;
            Administracion.FlatAppearance.BorderSize = 0;
            Administracion.FlatAppearance.MouseOverBackColor = Color.Gold;
            Administracion.FlatStyle = FlatStyle.Flat;
            Administracion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Administracion.ForeColor = SystemColors.ControlLight;
            Administracion.ImageAlign = ContentAlignment.MiddleLeft;
            Administracion.Location = new Point(47, 326);
            Administracion.Name = "Administracion";
            Administracion.Size = new Size(174, 46);
            Administracion.TabIndex = 15;
            Administracion.Text = "Administracion";
            Administracion.UseVisualStyleBackColor = false;
            Administracion.Click += btnbackup_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gold;
            panel6.Location = new Point(-7, 522);
            panel6.Name = "panel6";
            panel6.Size = new Size(5, 46);
            panel6.TabIndex = 14;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(6, 327);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(36, 46);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 534);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(36, 46);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gold;
            panel5.Location = new Point(3, 327);
            panel5.Name = "panel5";
            panel5.Size = new Size(5, 46);
            panel5.TabIndex = 13;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Gold;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLight;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(35, 531);
            button5.Name = "button5";
            button5.Size = new Size(185, 46);
            button5.TabIndex = 12;
            button5.Text = "Cerrar sesion";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(6, 275);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Location = new Point(3, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 46);
            panel4.TabIndex = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Gold;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLight;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(26, 276);
            button4.Name = "button4";
            button4.Size = new Size(194, 44);
            button4.TabIndex = 9;
            button4.Text = "Registro";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 223);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Location = new Point(3, 223);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 46);
            panel3.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Gold;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLight;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(6, 223);
            button3.Name = "button3";
            button3.Size = new Size(214, 46);
            button3.TabIndex = 6;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 171);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Location = new Point(3, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 46);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLight;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(6, 171);
            button2.Name = "button2";
            button2.Size = new Size(214, 46);
            button2.TabIndex = 3;
            button2.Text = "Citas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.barbero1;
            pictureBox2.Location = new Point(6, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Location = new Point(3, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 46);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Gold;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLight;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(6, 119);
            button1.Name = "button1";
            button1.Size = new Size(214, 46);
            button1.TabIndex = 0;
            button1.Text = "Barberos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(220, 35);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1380, 580);
            PanelContenedor.TabIndex = 2;
            PanelContenedor.Paint += PanelContenedor_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 615);
            Controls.Add(PanelContenedor);
            Controls.Add(BarraVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = " ";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            BarraVertical.ResumeLayout(false);
            Submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel BarraVertical;
        private PictureBox btnCerrar;
        private Panel PanelContenedor;
        private PictureBox btnMinimizar;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Button button2;
        private PictureBox pictureBox5;
        private Panel panel4;
        private Button button4;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button button3;
        private PictureBox pictureBox6;
        private Panel panel5;
        private Button button5;
        private Panel panel6;
        private PictureBox pictureBox7;
        private Button Administracion;
        private Panel Submenu;
        private Panel panel8;
        private Button button6;
        private Button button7;
    }
}