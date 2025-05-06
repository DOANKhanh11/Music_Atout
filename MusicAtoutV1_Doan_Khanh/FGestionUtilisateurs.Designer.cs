namespace MusicAtoutV1_Doan_Khanh
{
    partial class FGestionUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGestionUtilisateurs));
            pictureBox1 = new PictureBox();
            dataGridViewUtilisateurs = new DataGridView();
            idUtilisateurDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            droitsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actifDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nbessaisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsUtilisateur = new BindingSource(components);
            txtIdUtilisateur = new TextBox();
            txtNom = new TextBox();
            btnAjouterUtilisateur = new Button();
            btnReactiverCompte = new Button();
            btnDesactiverCompte = new Button();
            cboDroits = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtilisateurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateur).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-23, 800);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 17);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewUtilisateurs
            // 
            dataGridViewUtilisateurs.AutoGenerateColumns = false;
            dataGridViewUtilisateurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUtilisateurs.Columns.AddRange(new DataGridViewColumn[] { idUtilisateurDataGridViewTextBoxColumn, passwdDataGridViewTextBoxColumn, droitsDataGridViewTextBoxColumn, actifDataGridViewTextBoxColumn, nbessaisDataGridViewTextBoxColumn });
            dataGridViewUtilisateurs.DataSource = bsUtilisateur;
            dataGridViewUtilisateurs.Location = new Point(17, 38);
            dataGridViewUtilisateurs.Margin = new Padding(4, 5, 4, 5);
            dataGridViewUtilisateurs.Name = "dataGridViewUtilisateurs";
            dataGridViewUtilisateurs.RowHeadersWidth = 62;
            dataGridViewUtilisateurs.Size = new Size(777, 557);
            dataGridViewUtilisateurs.TabIndex = 1;
            // 
            // idUtilisateurDataGridViewTextBoxColumn
            // 
            idUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "IdUtilisateur";
            idUtilisateurDataGridViewTextBoxColumn.HeaderText = "IdUtilisateur";
            idUtilisateurDataGridViewTextBoxColumn.MinimumWidth = 8;
            idUtilisateurDataGridViewTextBoxColumn.Name = "idUtilisateurDataGridViewTextBoxColumn";
            idUtilisateurDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwdDataGridViewTextBoxColumn
            // 
            passwdDataGridViewTextBoxColumn.DataPropertyName = "Passwd";
            passwdDataGridViewTextBoxColumn.HeaderText = "Passwd";
            passwdDataGridViewTextBoxColumn.MinimumWidth = 8;
            passwdDataGridViewTextBoxColumn.Name = "passwdDataGridViewTextBoxColumn";
            passwdDataGridViewTextBoxColumn.Width = 150;
            // 
            // droitsDataGridViewTextBoxColumn
            // 
            droitsDataGridViewTextBoxColumn.DataPropertyName = "Droits";
            droitsDataGridViewTextBoxColumn.HeaderText = "Droits";
            droitsDataGridViewTextBoxColumn.MinimumWidth = 8;
            droitsDataGridViewTextBoxColumn.Name = "droitsDataGridViewTextBoxColumn";
            droitsDataGridViewTextBoxColumn.Width = 150;
            // 
            // actifDataGridViewTextBoxColumn
            // 
            actifDataGridViewTextBoxColumn.DataPropertyName = "Actif";
            actifDataGridViewTextBoxColumn.HeaderText = "Actif";
            actifDataGridViewTextBoxColumn.MinimumWidth = 8;
            actifDataGridViewTextBoxColumn.Name = "actifDataGridViewTextBoxColumn";
            actifDataGridViewTextBoxColumn.Width = 150;
            // 
            // nbessaisDataGridViewTextBoxColumn
            // 
            nbessaisDataGridViewTextBoxColumn.DataPropertyName = "Nbessais";
            nbessaisDataGridViewTextBoxColumn.HeaderText = "Nbessais";
            nbessaisDataGridViewTextBoxColumn.MinimumWidth = 8;
            nbessaisDataGridViewTextBoxColumn.Name = "nbessaisDataGridViewTextBoxColumn";
            nbessaisDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsUtilisateur
            // 
            bsUtilisateur.DataSource = typeof(Models.Utilisateur);
            // 
            // txtIdUtilisateur
            // 
            txtIdUtilisateur.Location = new Point(877, 77);
            txtIdUtilisateur.Margin = new Padding(4, 5, 4, 5);
            txtIdUtilisateur.Name = "txtIdUtilisateur";
            txtIdUtilisateur.Size = new Size(231, 31);
            txtIdUtilisateur.TabIndex = 2;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(877, 197);
            txtNom.Margin = new Padding(4, 5, 4, 5);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(231, 31);
            txtNom.TabIndex = 3;
            // 
            // btnAjouterUtilisateur
            // 
            btnAjouterUtilisateur.Location = new Point(877, 416);
            btnAjouterUtilisateur.Margin = new Padding(4, 5, 4, 5);
            btnAjouterUtilisateur.Name = "btnAjouterUtilisateur";
            btnAjouterUtilisateur.Size = new Size(107, 38);
            btnAjouterUtilisateur.TabIndex = 7;
            btnAjouterUtilisateur.Text = "Ajouter ";
            btnAjouterUtilisateur.UseVisualStyleBackColor = true;
            btnAjouterUtilisateur.Click += btnAjouterUtilisateur_Click;
            // 
            // btnReactiverCompte
            // 
            btnReactiverCompte.Location = new Point(489, 625);
            btnReactiverCompte.Margin = new Padding(4, 5, 4, 5);
            btnReactiverCompte.Name = "btnReactiverCompte";
            btnReactiverCompte.Size = new Size(107, 38);
            btnReactiverCompte.TabIndex = 8;
            btnReactiverCompte.Text = "Reactive";
            btnReactiverCompte.UseVisualStyleBackColor = true;
            btnReactiverCompte.Click += btnReactiverCompte_Click;
            // 
            // btnDesactiverCompte
            // 
            btnDesactiverCompte.Location = new Point(90, 625);
            btnDesactiverCompte.Margin = new Padding(4, 5, 4, 5);
            btnDesactiverCompte.Name = "btnDesactiverCompte";
            btnDesactiverCompte.Size = new Size(107, 38);
            btnDesactiverCompte.TabIndex = 9;
            btnDesactiverCompte.Text = "Déactive";
            btnDesactiverCompte.UseVisualStyleBackColor = true;
            btnDesactiverCompte.Click += btnDesactiverCompte_Click;
            // 
            // cboDroits
            // 
            cboDroits.FormattingEnabled = true;
            cboDroits.Items.AddRange(new object[] { "1 - Lecture", "2 - Écriture", "3 - Administration" });
            cboDroits.Location = new Point(877, 308);
            cboDroits.Margin = new Padding(4, 5, 4, 5);
            cboDroits.Name = "cboDroits";
            cboDroits.Size = new Size(231, 33);
            cboDroits.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(880, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 11;
            label1.Text = "Id Utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(877, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 12;
            label2.Text = "Nom Utilisateur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(877, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 13;
            label3.Text = "Droit";
            // 
            // FGestionUtilisateurs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboDroits);
            Controls.Add(btnDesactiverCompte);
            Controls.Add(btnReactiverCompte);
            Controls.Add(btnAjouterUtilisateur);
            Controls.Add(txtNom);
            Controls.Add(txtIdUtilisateur);
            Controls.Add(dataGridViewUtilisateurs);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FGestionUtilisateurs";
            Text = "FGestionUtilisateurs";
            Load += FGestionUtilisateurs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUtilisateurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewUtilisateurs;
        private TextBox txtIdUtilisateur;
        private TextBox txtNom;
        private Button btnAjouterUtilisateur;
        private Button btnReactiverCompte;
        private Button btnDesactiverCompte;
        private DataGridViewTextBoxColumn idUtilisateurDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn droitsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actifDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nbessaisDataGridViewTextBoxColumn;
        private BindingSource bsUtilisateur;
        private ComboBox cboDroits;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}