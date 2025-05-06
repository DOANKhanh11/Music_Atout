namespace MusicAtoutV1_Doan_Khanh.Models
{
    partial class FConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConnexion));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUtilisateur = new TextBox();
            txtPasswd = new TextBox();
            btnConnexion = new Button();
            btnChangerMDP = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-16, 2);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1439, 827);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUtilisateur
            // 
            txtUtilisateur.Location = new Point(156, 27);
            txtUtilisateur.Margin = new Padding(4, 5, 4, 5);
            txtUtilisateur.Name = "txtUtilisateur";
            txtUtilisateur.Size = new Size(168, 31);
            txtUtilisateur.TabIndex = 3;
            // 
            // txtPasswd
            // 
            txtPasswd.Location = new Point(156, 98);
            txtPasswd.Margin = new Padding(4, 5, 4, 5);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.PasswordChar = '*';
            txtPasswd.ShortcutsEnabled = false;
            txtPasswd.Size = new Size(171, 31);
            txtPasswd.TabIndex = 4;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(266, 161);
            btnConnexion.Margin = new Padding(4, 5, 4, 5);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(61, 33);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "OK";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // btnChangerMDP
            // 
            btnChangerMDP.Location = new Point(156, 214);
            btnChangerMDP.Name = "btnChangerMDP";
            btnChangerMDP.Size = new Size(171, 34);
            btnChangerMDP.TabIndex = 6;
            btnChangerMDP.Text = "Changer MDP";
            btnChangerMDP.UseVisualStyleBackColor = true;
            btnChangerMDP.Click += btnChangerMDP_Click;
            // 
            // FConnexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 827);
            Controls.Add(btnChangerMDP);
            Controls.Add(btnConnexion);
            Controls.Add(txtPasswd);
            Controls.Add(txtUtilisateur);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FConnexion";
            Text = "FConnexion";
            Load += FConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUtilisateur;
        private TextBox txtPasswd;
        private Button btnConnexion;
        private Button btnChangerMDP;
    }
}