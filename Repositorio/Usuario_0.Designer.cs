namespace Barber_Royal
{
    partial class Usuario_0
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre_US = new TextBox();
            txtCorreo = new TextBox();
            txtContrasena = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(270, 37);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(67, 66);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(67, 111);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(67, 161);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 210);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // txtNombre_US
            // 
            txtNombre_US.BackColor = SystemColors.ActiveBorder;
            txtNombre_US.BorderStyle = BorderStyle.None;
            txtNombre_US.Location = new Point(67, 83);
            txtNombre_US.Margin = new Padding(3, 2, 3, 2);
            txtNombre_US.Name = "txtNombre_US";
            txtNombre_US.Size = new Size(173, 16);
            txtNombre_US.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.ActiveBorder;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Location = new Point(67, 128);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(173, 16);
            txtCorreo.TabIndex = 6;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.ActiveBorder;
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Location = new Point(67, 178);
            txtContrasena.Margin = new Padding(3, 2, 3, 2);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(173, 16);
            txtContrasena.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.ActiveBorder;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Location = new Point(67, 227);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(173, 16);
            txtTelefono.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Gold;
            btnAgregar.FlatAppearance.BorderColor = Color.Gold;
            btnAgregar.FlatAppearance.BorderSize = 3;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(67, 269);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(173, 36);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Gold;
            btnLimpiar.Location = new Point(67, 309);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 36);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNombre_US);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(179, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 425);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // Usuario_0
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(723, 474);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuario_0";
            Text = "Usuario_0";
            Load += Usuario_0_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre_US;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Panel panel1;
    }
}