namespace Barber_Royal
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
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            Tutorial = new Label();
            btnVerificar = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Gold;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(25, 229);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(233, 33);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Iniciar sesion ";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Desktop;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(86, 56);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 24);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Desktop;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(86, 153);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 24);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(219, 265);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 11;
            label3.Text = "Salir";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(200, 201);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 10;
            label2.Text = "Limpiar";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = Properties.Resources.baber;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Tutorial);
            panel1.Controls.Add(btnVerificar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(73, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 357);
            panel1.TabIndex = 12;
            // 
            // Tutorial
            // 
            Tutorial.AutoSize = true;
            Tutorial.BackColor = Color.Transparent;
            Tutorial.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tutorial.ForeColor = Color.Gold;
            Tutorial.Location = new Point(198, 320);
            Tutorial.Name = "Tutorial";
            Tutorial.Size = new Size(60, 16);
            Tutorial.TabIndex = 13;
            Tutorial.Text = "Tutorial";
            Tutorial.Click += Tutorial_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.Gold;
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(25, 284);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(233, 33);
            btnVerificar.TabIndex = 14;
            btnVerificar.Text = "Registrarse";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Location = new Point(25, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 1);
            panel3.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Location = new Point(25, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 1);
            panel2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(452, 639);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnVerificar;
        private Label Tutorial;
    }
}
