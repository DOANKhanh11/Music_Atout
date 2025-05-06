namespace MusicAtoutV1_Doan_Khanh
{
    partial class FSalle
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
            bsSalle = new BindingSource(components);
            dgvSalle = new DataGridView();
            idBatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numSalleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomSalleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capaciteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            superficieDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idBatiNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idTypesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsSalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalle).BeginInit();
            SuspendLayout();
            // 
            // bsSalle
            // 
            bsSalle.DataSource = typeof(Models.Salle);
            // 
            // dgvSalle
            // 
            dgvSalle.AllowUserToAddRows = false;
            dgvSalle.AllowUserToDeleteRows = false;
            dgvSalle.AutoGenerateColumns = false;
            dgvSalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalle.Columns.AddRange(new DataGridViewColumn[] { idBatiDataGridViewTextBoxColumn, numSalleDataGridViewTextBoxColumn, nomSalleDataGridViewTextBoxColumn, capaciteDataGridViewTextBoxColumn, superficieDataGridViewTextBoxColumn, idBatiNavigationDataGridViewTextBoxColumn, idTypesDataGridViewTextBoxColumn });
            dgvSalle.DataSource = bsSalle;
            dgvSalle.Location = new Point(0, 1);
            dgvSalle.Name = "dgvSalle";
            dgvSalle.ReadOnly = true;
            dgvSalle.Size = new Size(744, 450);
            dgvSalle.TabIndex = 0;
            // 
            // idBatiDataGridViewTextBoxColumn
            // 
            idBatiDataGridViewTextBoxColumn.DataPropertyName = "IdBati";
            idBatiDataGridViewTextBoxColumn.HeaderText = "IdBati";
            idBatiDataGridViewTextBoxColumn.Name = "idBatiDataGridViewTextBoxColumn";
            idBatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numSalleDataGridViewTextBoxColumn
            // 
            numSalleDataGridViewTextBoxColumn.DataPropertyName = "NumSalle";
            numSalleDataGridViewTextBoxColumn.HeaderText = "NumSalle";
            numSalleDataGridViewTextBoxColumn.Name = "numSalleDataGridViewTextBoxColumn";
            numSalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomSalleDataGridViewTextBoxColumn
            // 
            nomSalleDataGridViewTextBoxColumn.DataPropertyName = "NomSalle";
            nomSalleDataGridViewTextBoxColumn.HeaderText = "NomSalle";
            nomSalleDataGridViewTextBoxColumn.Name = "nomSalleDataGridViewTextBoxColumn";
            nomSalleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capaciteDataGridViewTextBoxColumn
            // 
            capaciteDataGridViewTextBoxColumn.DataPropertyName = "Capacite";
            capaciteDataGridViewTextBoxColumn.HeaderText = "Capacite";
            capaciteDataGridViewTextBoxColumn.Name = "capaciteDataGridViewTextBoxColumn";
            capaciteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // superficieDataGridViewTextBoxColumn
            // 
            superficieDataGridViewTextBoxColumn.DataPropertyName = "Superficie";
            superficieDataGridViewTextBoxColumn.HeaderText = "Superficie";
            superficieDataGridViewTextBoxColumn.Name = "superficieDataGridViewTextBoxColumn";
            superficieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idBatiNavigationDataGridViewTextBoxColumn
            // 
            idBatiNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdBatiNavigation";
            idBatiNavigationDataGridViewTextBoxColumn.HeaderText = "IdBatiNavigation";
            idBatiNavigationDataGridViewTextBoxColumn.Name = "idBatiNavigationDataGridViewTextBoxColumn";
            idBatiNavigationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTypesDataGridViewTextBoxColumn
            // 
            idTypesDataGridViewTextBoxColumn.DataPropertyName = "IdTypes";
            idTypesDataGridViewTextBoxColumn.HeaderText = "IdTypes";
            idTypesDataGridViewTextBoxColumn.Name = "idTypesDataGridViewTextBoxColumn";
            idTypesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FSalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSalle);
            Name = "FSalle";
            Text = "FSalle";
            Load += FSalle_Load_1;
            ((System.ComponentModel.ISupportInitialize)bsSalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsSalle;
        private DataGridView dgvSalle;
        private DataGridViewTextBoxColumn idBatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numSalleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomSalleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capaciteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn superficieDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBatiNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTypesDataGridViewTextBoxColumn;
    }
}