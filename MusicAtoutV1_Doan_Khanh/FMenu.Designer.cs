namespace MusicAtoutV1_Doan_Khanh
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            menuStrip1 = new MenuStrip();
            lISTEToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            sALLESToolStripMenuItem = new ToolStripMenuItem();
            bATIMENTToolStripMenuItem = new ToolStripMenuItem();
            tYPESDOEUVREToolStripMenuItem = new ToolStripMenuItem();
            cOMPOSITEURToolStripMenuItem = new ToolStripMenuItem();
            parNationalitéToolStripMenuItem = new ToolStripMenuItem();
            parToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btnDeconnexion = new Button();
            gestionDesUtilisateursToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { lISTEToolStripMenuItem, cOMPOSITEURToolStripMenuItem, gestionDesUtilisateursToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // lISTEToolStripMenuItem
            // 
            lISTEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, sALLESToolStripMenuItem, bATIMENTToolStripMenuItem, tYPESDOEUVREToolStripMenuItem });
            lISTEToolStripMenuItem.Name = "lISTEToolStripMenuItem";
            lISTEToolStripMenuItem.Size = new Size(47, 20);
            lISTEToolStripMenuItem.Text = "LISTE";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(164, 22);
            toolStripMenuItem1.Text = "VILLES";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // sALLESToolStripMenuItem
            // 
            sALLESToolStripMenuItem.Name = "sALLESToolStripMenuItem";
            sALLESToolStripMenuItem.Size = new Size(164, 22);
            sALLESToolStripMenuItem.Text = "SALLES";
            sALLESToolStripMenuItem.Click += sALLESToolStripMenuItem_Click_1;
            // 
            // bATIMENTToolStripMenuItem
            // 
            bATIMENTToolStripMenuItem.Name = "bATIMENTToolStripMenuItem";
            bATIMENTToolStripMenuItem.Size = new Size(164, 22);
            bATIMENTToolStripMenuItem.Text = "BATIMENT";
            bATIMENTToolStripMenuItem.Click += bATIMENTToolStripMenuItem_Click;
            // 
            // tYPESDOEUVREToolStripMenuItem
            // 
            tYPESDOEUVREToolStripMenuItem.Name = "tYPESDOEUVREToolStripMenuItem";
            tYPESDOEUVREToolStripMenuItem.Size = new Size(164, 22);
            tYPESDOEUVREToolStripMenuItem.Text = "TYPES D'OEUVRE";
            tYPESDOEUVREToolStripMenuItem.Click += tYPESDOEUVREToolStripMenuItem_Click_1;
            // 
            // cOMPOSITEURToolStripMenuItem
            // 
            cOMPOSITEURToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parNationalitéToolStripMenuItem, parToolStripMenuItem });
            cOMPOSITEURToolStripMenuItem.Name = "cOMPOSITEURToolStripMenuItem";
            cOMPOSITEURToolStripMenuItem.Size = new Size(100, 20);
            cOMPOSITEURToolStripMenuItem.Text = "COMPOSITEUR";
            // 
            // parNationalitéToolStripMenuItem
            // 
            parNationalitéToolStripMenuItem.Name = "parNationalitéToolStripMenuItem";
            parNationalitéToolStripMenuItem.Size = new Size(180, 22);
            parNationalitéToolStripMenuItem.Text = "par nationalité";
            parNationalitéToolStripMenuItem.Click += parNationalitéToolStripMenuItem_Click;
            // 
            // parToolStripMenuItem
            // 
            parToolStripMenuItem.Name = "parToolStripMenuItem";
            parToolStripMenuItem.Size = new Size(180, 22);
            parToolStripMenuItem.Text = "par style";
            parToolStripMenuItem.Click += parToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(709, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Location = new Point(661, 414);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(109, 23);
            btnDeconnexion.TabIndex = 2;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = true;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            gestionDesUtilisateursToolStripMenuItem.Size = new Size(140, 20);
            gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            gestionDesUtilisateursToolStripMenuItem.Click += gestionDesUtilisateursToolStripMenuItem_Click;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeconnexion);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            Text = "FMenu";
            Load += FMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem lISTEToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sALLESToolStripMenuItem;
        private ToolStripMenuItem bATIMENTToolStripMenuItem;
        private ToolStripMenuItem tYPESDOEUVREToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem cOMPOSITEURToolStripMenuItem;
        private ToolStripMenuItem parNationalitéToolStripMenuItem;
        private ToolStripMenuItem parToolStripMenuItem;
        private Button btnDeconnexion;
        private ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
    }
}