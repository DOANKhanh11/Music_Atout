namespace MusicAtoutV1_Doan_Khanh
{
    partial class FAjoutModifCompositeur
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtAnNais = new TextBox();
            txtAnMort = new TextBox();
            txtRemarque = new RichTextBox();
            cboNation = new ComboBox();
            cboStyle = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            bsStyle = new BindingSource(components);
            bsNation = new BindingSource(components);
            bsCompositeur = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "nom Compositeur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "prenom Compositeur :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 129);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "remarque :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 251);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "an Nais : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 251);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "an Mort :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 294);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 5;
            label6.Text = "Nationalité : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 338);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Style :";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(168, 40);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(139, 23);
            txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(168, 79);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(139, 23);
            txtPrenom.TabIndex = 8;
            // 
            // txtAnNais
            // 
            txtAnNais.Location = new Point(168, 251);
            txtAnNais.Name = "txtAnNais";
            txtAnNais.Size = new Size(100, 23);
            txtAnNais.TabIndex = 9;
            // 
            // txtAnMort
            // 
            txtAnMort.Location = new Point(490, 248);
            txtAnMort.Name = "txtAnMort";
            txtAnMort.Size = new Size(100, 23);
            txtAnMort.TabIndex = 10;
            // 
            // txtRemarque
            // 
            txtRemarque.Location = new Point(168, 126);
            txtRemarque.Name = "txtRemarque";
            txtRemarque.Size = new Size(598, 116);
            txtRemarque.TabIndex = 11;
            txtRemarque.Text = "";
            // 
            // cboNation
            // 
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(167, 289);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(121, 23);
            cboNation.TabIndex = 12;
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(167, 330);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(121, 23);
            cboStyle.TabIndex = 13;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(165, 388);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(62, 23);
            btnOk.TabIndex = 14;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(261, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(64, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // bsCompositeur
            // 
            bsCompositeur.CurrentChanged += bsCompositeur_CurrentChanged;
            // 
            // FAjoutModifCompositeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cboStyle);
            Controls.Add(cboNation);
            Controls.Add(txtRemarque);
            Controls.Add(txtAnMort);
            Controls.Add(txtAnNais);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FAjoutModifCompositeur";
            Text = "FGestionCompositeur";
            Load += FAjoutModifCompositeur_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtAnNais;
        private TextBox txtAnMort;
        private RichTextBox txtRemarque;
        private ComboBox cboNation;
        private ComboBox cboStyle;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private BindingSource bsStyle;
        private BindingSource bsNation;
        private BindingSource bsCompositeur;
    }
}