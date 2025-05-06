namespace MusicAtoutV1_Doan_Khanh
{
    partial class FCompositeurNation
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
            bsCompositeur = new BindingSource(components);
            dgvCompositeur = new DataGridView();
            cboNation = new ComboBox();
            bsNation = new BindingSource(components);
            button1 = new Button();
            btnAjout = new Button();
            btnModif = new Button();
            btnSuppression = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // bsCompositeur
            // 
            bsCompositeur.CurrentChanged += bsCompositeur_CurrentChanged;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(12, 50);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.Size = new Size(776, 345);
            dgvCompositeur.TabIndex = 0;
            // 
            // cboNation
            // 
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(12, 12);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(121, 23);
            cboNation.TabIndex = 1;
            // 
            // bsNation
            // 
            bsNation.CurrentChanged += bsNation_CurrentChanged;
            // 
            // button1
            // 
            button1.Location = new Point(155, 14);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 2;
            button1.Text = "Toutes les nationalités";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(58, 414);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(75, 23);
            btnAjout.TabIndex = 3;
            btnAjout.Text = "AJOUT";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // btnModif
            // 
            btnModif.Location = new Point(139, 415);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(100, 23);
            btnModif.TabIndex = 4;
            btnModif.Text = "MODIFICATION";
            btnModif.UseVisualStyleBackColor = true;
            btnModif.Click += btnModif_Click;
            // 
            // btnSuppression
            // 
            btnSuppression.Location = new Point(245, 415);
            btnSuppression.Name = "btnSuppression";
            btnSuppression.Size = new Size(90, 23);
            btnSuppression.TabIndex = 5;
            btnSuppression.Text = "SUPPRESSION";
            btnSuppression.UseVisualStyleBackColor = true;
            btnSuppression.Click += btnSuppression_Click;
            // 
            // FCompositeurNation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSuppression);
            Controls.Add(btnModif);
            Controls.Add(btnAjout);
            Controls.Add(button1);
            Controls.Add(cboNation);
            Controls.Add(dgvCompositeur);
            Name = "FCompositeurNation";
            Text = "FCompositeurNation";
            Activated += FCompositeurNation_Activated;
            Load += FCompositeurNation_Load;
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsCompositeur;
        private DataGridView dgvCompositeur;
        private ComboBox cboNation;
        private BindingSource bsNation;
        private Button button1;
        private Button btnAjout;
        private Button btnModif;
        private Button btnSuppression;
        private BindingSource bindingSource1;
    }
}