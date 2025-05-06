namespace MusicAtoutV1_Doan_Khanh
{
    partial class FChangerMotDePasse
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
            txtAncienMDP = new TextBox();
            txtNouveauMDP = new TextBox();
            txtConfirmation = new TextBox();
            btnChangerMDP = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtAncienMDP
            // 
            txtAncienMDP.Location = new Point(337, 165);
            txtAncienMDP.Margin = new Padding(4, 5, 4, 5);
            txtAncienMDP.Name = "txtAncienMDP";
            txtAncienMDP.PasswordChar = '*';
            txtAncienMDP.Size = new Size(398, 31);
            txtAncienMDP.TabIndex = 0;
            // 
            // txtNouveauMDP
            // 
            txtNouveauMDP.Location = new Point(337, 300);
            txtNouveauMDP.Margin = new Padding(4, 5, 4, 5);
            txtNouveauMDP.Name = "txtNouveauMDP";
            txtNouveauMDP.PasswordChar = '*';
            txtNouveauMDP.Size = new Size(398, 31);
            txtNouveauMDP.TabIndex = 1;
            // 
            // txtConfirmation
            // 
            txtConfirmation.Location = new Point(337, 438);
            txtConfirmation.Margin = new Padding(4, 5, 4, 5);
            txtConfirmation.Name = "txtConfirmation";
            txtConfirmation.PasswordChar = '*';
            txtConfirmation.Size = new Size(398, 31);
            txtConfirmation.TabIndex = 2;
            // 
            // btnChangerMDP
            // 
            btnChangerMDP.Location = new Point(759, 585);
            btnChangerMDP.Margin = new Padding(4, 5, 4, 5);
            btnChangerMDP.Name = "btnChangerMDP";
            btnChangerMDP.Size = new Size(119, 53);
            btnChangerMDP.TabIndex = 3;
            btnChangerMDP.Text = "Valider";
            btnChangerMDP.UseVisualStyleBackColor = true;
            btnChangerMDP.Click += btnChangerMDP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 135);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 25);
            label1.TabIndex = 5;
            label1.Text = "Votre Ancien Mot De Passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 270);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 25);
            label2.TabIndex = 6;
            label2.Text = "Votre Nouveau Mot De Passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 408);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(352, 25);
            label3.TabIndex = 7;
            label3.Text = "Confirmation Votre Nouveau Mot De Passe";
            // 
            // FChangerMotDePasse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChangerMDP);
            Controls.Add(txtConfirmation);
            Controls.Add(txtNouveauMDP);
            Controls.Add(txtAncienMDP);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FChangerMotDePasse";
            Text = "FChangerMotDePasse";
            Load += FChangerMotDePasse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAncienMDP;
        private TextBox txtNouveauMDP;
        private TextBox txtConfirmation;
        private Button btnChangerMDP;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}