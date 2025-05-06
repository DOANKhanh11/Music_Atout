namespace MusicAtoutV1_Doan_Khanh
{
    partial class FCompositeurStyle
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
            cboStyle = new ComboBox();
            dgvCompositeur = new DataGridView();
            bsStyle = new BindingSource(components);
            txtDebut = new TextBox();
            txtFin = new TextBox();
            bsCompositeur = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            SuspendLayout();
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(208, 28);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(151, 23);
            cboStyle.TabIndex = 0;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(26, 88);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.Size = new Size(753, 350);
            dgvCompositeur.TabIndex = 1;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // txtDebut
            // 
            txtDebut.Location = new Point(446, 27);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(100, 23);
            txtDebut.TabIndex = 2;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(645, 28);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(100, 23);
            txtFin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 4;
            label1.Text = "Sélectionner un style ou époque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Date du style";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(572, 31);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Fin du style";
            // 
            // FCompositeurStyle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(dgvCompositeur);
            Controls.Add(cboStyle);
            Name = "FCompositeurStyle";
            Text = "FCompositeurStyle";
            Activated += FCompositeurStyle_Activated;
            Load += FCompositeurStyle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboStyle;
        private DataGridView dgvCompositeur;
        private BindingSource bsStyle;
        private TextBox txtDebut;
        private TextBox txtFin;
        private BindingSource bsCompositeur;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}