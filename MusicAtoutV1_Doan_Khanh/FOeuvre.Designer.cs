namespace MusicAtoutV1_Doan_Khanh
{
    partial class FOeuvre
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOeuvre));
            cboStyle = new ComboBox();
            txtDebut = new TextBox();
            txtFin = new TextBox();
            dgvCompositeur = new DataGridView();
            txtCompositeur = new TextBox();
            txtNationalite = new TextBox();
            txtStyle = new TextBox();
            txtNaissance = new TextBox();
            txtDeces = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            txtInfo = new RichTextBox();
            dgvOeuvre = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            bsStyle = new BindingSource(components);
            bsCompositeur = new BindingSource(components);
            bsOeuvre = new BindingSource(components);
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOeuvre).BeginInit();
            SuspendLayout();
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(25, 102);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(166, 23);
            cboStyle.TabIndex = 0;
            cboStyle.SelectedIndexChanged += cboStyle_SelectedIndexChanged;
            // 
            // txtDebut
            // 
            txtDebut.Location = new Point(24, 146);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(63, 23);
            txtDebut.TabIndex = 1;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(125, 146);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(61, 23);
            txtFin.TabIndex = 2;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.AllowUserToAddRows = false;
            dgvCompositeur.AllowUserToDeleteRows = false;
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(20, 204);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.ReadOnly = true;
            dgvCompositeur.Size = new Size(372, 331);
            dgvCompositeur.TabIndex = 3;
            dgvCompositeur.CellContentClick += dgvCompositeur_CellContentClick;
            // 
            // txtCompositeur
            // 
            txtCompositeur.Location = new Point(170, 28);
            txtCompositeur.Name = "txtCompositeur";
            txtCompositeur.Size = new Size(318, 23);
            txtCompositeur.TabIndex = 4;
            // 
            // txtNationalite
            // 
            txtNationalite.Location = new Point(170, 64);
            txtNationalite.Name = "txtNationalite";
            txtNationalite.Size = new Size(141, 23);
            txtNationalite.TabIndex = 5;
            // 
            // txtStyle
            // 
            txtStyle.Location = new Point(355, 64);
            txtStyle.Name = "txtStyle";
            txtStyle.Size = new Size(133, 23);
            txtStyle.TabIndex = 6;
            // 
            // txtNaissance
            // 
            txtNaissance.Location = new Point(170, 102);
            txtNaissance.Name = "txtNaissance";
            txtNaissance.Size = new Size(82, 23);
            txtNaissance.TabIndex = 7;
            // 
            // txtDeces
            // 
            txtDeces.Location = new Point(317, 102);
            txtDeces.Name = "txtDeces";
            txtDeces.Size = new Size(74, 23);
            txtDeces.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 84);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 9;
            label1.Text = "Style";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 128);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 10;
            label2.Text = "Début";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 128);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 11;
            label3.Text = "Fin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 36);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 12;
            label4.Text = "Vous avez sélectionné";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 70);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 13;
            label5.Text = "Nationalité";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 70);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 14;
            label6.Text = "Style";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 110);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 15;
            label7.Text = "Naissance";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(txtInfo);
            panel1.Controls.Add(dgvOeuvre);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDeces);
            panel1.Controls.Add(txtNaissance);
            panel1.Controls.Add(txtStyle);
            panel1.Controls.Add(txtNationalite);
            panel1.Controls.Add(txtCompositeur);
            panel1.Location = new Point(462, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 563);
            panel1.TabIndex = 16;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(43, 142);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(445, 79);
            txtInfo.TabIndex = 20;
            txtInfo.Text = "";
            // 
            // dgvOeuvre
            // 
            dgvOeuvre.AllowUserToAddRows = false;
            dgvOeuvre.AllowUserToDeleteRows = false;
            dgvOeuvre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOeuvre.Location = new Point(43, 242);
            dgvOeuvre.Name = "dgvOeuvre";
            dgvOeuvre.ReadOnly = true;
            dgvOeuvre.Size = new Size(445, 293);
            dgvOeuvre.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 224);
            label9.Name = "label9";
            label9.Size = new Size(169, 15);
            label9.TabIndex = 18;
            label9.Text = "Les oeuvres de ce compositeur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(268, 105);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "Décès";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // bsCompositeur
            // 
            bsCompositeur.CurrentChanged += bsCompositeur_CurrentChanged_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(75, 36);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 18;
            label10.Text = "Atout";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 179);
            label11.Name = "label11";
            label11.Size = new Size(139, 15);
            label11.TabIndex = 19;
            label11.Text = "Compositeurs de ce style";
            // 
            // FOeuvre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(cboStyle);
            Controls.Add(dgvCompositeur);
            ForeColor = SystemColors.InfoText;
            Name = "FOeuvre";
            Text = "FOeuvre";
            Load += FOeuvre_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOeuvre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboStyle;
        private TextBox txtDebut;
        private TextBox txtFin;
        private DataGridView dgvCompositeur;
        private TextBox txtCompositeur;
        private TextBox txtNationalite;
        private TextBox txtStyle;
        private TextBox txtNaissance;
        private TextBox txtDeces;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private DataGridView dgvOeuvre;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private BindingSource bsStyle;
        private BindingSource bsCompositeur;
        private BindingSource bsOeuvre;
        private Label label10;
        private Label label11;
        private RichTextBox txtInfo;
    }
}