namespace Barber_Royal
{
    partial class Backup
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
            btnBackup = new Button();
            btnRestore = new Button();
            lblBackup = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.Gold;
            btnBackup.FlatStyle = FlatStyle.Popup;
            btnBackup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackup.ForeColor = Color.Gold;
            btnBackup.Image = Properties.Resources.BarberShopRoyal___BackGround__;
            btnBackup.Location = new Point(286, 381);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(120, 47);
            btnBackup.TabIndex = 0;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.Gold;
            btnRestore.FlatStyle = FlatStyle.Popup;
            btnRestore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRestore.ForeColor = Color.Gold;
            btnRestore.Image = Properties.Resources.BarberShopRoyal___BackGround__;
            btnRestore.Location = new Point(431, 381);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(120, 47);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackup.ForeColor = Color.Gold;
            lblBackup.Location = new Point(232, 283);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(401, 35);
            lblBackup.TabIndex = 2;
            lblBackup.Text = "Bienvenido al centro de respaldo";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.crown;
            groupBox1.Controls.Add(btnBackup);
            groupBox1.Controls.Add(lblBackup);
            groupBox1.Controls.Add(btnRestore);
            groupBox1.Location = new Point(502, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(844, 697);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Backup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1559, 721);
            Controls.Add(groupBox1);
            Name = "Backup";
            Text = "Backup";
            Load += Backup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackup;
        private Button btnRestore;
        private Label lblBackup;
        private GroupBox groupBox1;
    }
}