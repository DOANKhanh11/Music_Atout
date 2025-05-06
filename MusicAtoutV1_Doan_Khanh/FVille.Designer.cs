namespace MusicAtoutV1_Doan_Khanh
{
    partial class FVille
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
            bsVille = new BindingSource(components);
            dgvVille = new DataGridView();
            idVilleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomVilleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departementDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            batimentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsVille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVille).BeginInit();
            SuspendLayout();
            // 
            // bsVille
            // 
            bsVille.DataSource = typeof(Models.Ville);
            bsVille.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dgvVille
            // 
            dgvVille.AllowUserToAddRows = false;
            dgvVille.AllowUserToDeleteRows = false;
            dgvVille.AutoGenerateColumns = false;
            dgvVille.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVille.Columns.AddRange(new DataGridViewColumn[] { idVilleDataGridViewTextBoxColumn, nomVilleDataGridViewTextBoxColumn, departementDataGridViewTextBoxColumn, batimentsDataGridViewTextBoxColumn });
            dgvVille.DataSource = bsVille;
            dgvVille.Location = new Point(-1, 0);
            dgvVille.Name = "dgvVille";
            dgvVille.ReadOnly = true;
            dgvVille.Size = new Size(441, 450);
            dgvVille.TabIndex = 0;
            // 
            // idVilleDataGridViewTextBoxColumn
            // 
            idVilleDataGridViewTextBoxColumn.DataPropertyName = "IdVille";
            idVilleDataGridViewTextBoxColumn.HeaderText = "IdVille";
            idVilleDataGridViewTextBoxColumn.Name = "idVilleDataGridViewTextBoxColumn";
            idVilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomVilleDataGridViewTextBoxColumn
            // 
            nomVilleDataGridViewTextBoxColumn.DataPropertyName = "NomVille";
            nomVilleDataGridViewTextBoxColumn.HeaderText = "NomVille";
            nomVilleDataGridViewTextBoxColumn.Name = "nomVilleDataGridViewTextBoxColumn";
            nomVilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departementDataGridViewTextBoxColumn
            // 
            departementDataGridViewTextBoxColumn.DataPropertyName = "Departement";
            departementDataGridViewTextBoxColumn.HeaderText = "Departement";
            departementDataGridViewTextBoxColumn.Name = "departementDataGridViewTextBoxColumn";
            departementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batimentsDataGridViewTextBoxColumn
            // 
            batimentsDataGridViewTextBoxColumn.DataPropertyName = "Batiments";
            batimentsDataGridViewTextBoxColumn.HeaderText = "Batiments";
            batimentsDataGridViewTextBoxColumn.Name = "batimentsDataGridViewTextBoxColumn";
            batimentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FVille
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVille);
            Name = "FVille";
            Text = "FVille";
            Load += FVille_Load;
            ((System.ComponentModel.ISupportInitialize)bsVille).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVille).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsVille;
        private DataGridView dgvVille;
        private DataGridViewTextBoxColumn idVilleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomVilleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn batimentsDataGridViewTextBoxColumn;
    }
}