namespace MusicAtoutV1_Doan_Khanh
{
    partial class FBati
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
            bsBati = new BindingSource(components);
            dgvBati = new DataGridView();
            idBatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomBatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anConstructionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rueBatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cpBatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telBatiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responsableDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idVilleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idVilleNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sallesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            batimentBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsBati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)batimentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bsBati
            // 
            bsBati.DataSource = typeof(Models.Batiment);
            // 
            // dgvBati
            // 
            dgvBati.AllowUserToAddRows = false;
            dgvBati.AllowUserToDeleteRows = false;
            dgvBati.AutoGenerateColumns = false;
            dgvBati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBati.Columns.AddRange(new DataGridViewColumn[] { idBatiDataGridViewTextBoxColumn, nomBatiDataGridViewTextBoxColumn, anConstructionDataGridViewTextBoxColumn, rueBatiDataGridViewTextBoxColumn, cpBatiDataGridViewTextBoxColumn, telBatiDataGridViewTextBoxColumn, responsableDataGridViewTextBoxColumn, idVilleDataGridViewTextBoxColumn, idVilleNavigationDataGridViewTextBoxColumn, sallesDataGridViewTextBoxColumn });
            dgvBati.DataSource = bsBati;
            dgvBati.Location = new Point(1, 0);
            dgvBati.Name = "dgvBati";
            dgvBati.ReadOnly = true;
            dgvBati.Size = new Size(804, 454);
            dgvBati.TabIndex = 0;
            // 
            // idBatiDataGridViewTextBoxColumn
            // 
            idBatiDataGridViewTextBoxColumn.DataPropertyName = "IdBati";
            idBatiDataGridViewTextBoxColumn.HeaderText = "IdBati";
            idBatiDataGridViewTextBoxColumn.Name = "idBatiDataGridViewTextBoxColumn";
            idBatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomBatiDataGridViewTextBoxColumn
            // 
            nomBatiDataGridViewTextBoxColumn.DataPropertyName = "NomBati";
            nomBatiDataGridViewTextBoxColumn.HeaderText = "NomBati";
            nomBatiDataGridViewTextBoxColumn.Name = "nomBatiDataGridViewTextBoxColumn";
            nomBatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anConstructionDataGridViewTextBoxColumn
            // 
            anConstructionDataGridViewTextBoxColumn.DataPropertyName = "AnConstruction";
            anConstructionDataGridViewTextBoxColumn.HeaderText = "AnConstruction";
            anConstructionDataGridViewTextBoxColumn.Name = "anConstructionDataGridViewTextBoxColumn";
            anConstructionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rueBatiDataGridViewTextBoxColumn
            // 
            rueBatiDataGridViewTextBoxColumn.DataPropertyName = "RueBati";
            rueBatiDataGridViewTextBoxColumn.HeaderText = "RueBati";
            rueBatiDataGridViewTextBoxColumn.Name = "rueBatiDataGridViewTextBoxColumn";
            rueBatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpBatiDataGridViewTextBoxColumn
            // 
            cpBatiDataGridViewTextBoxColumn.DataPropertyName = "CpBati";
            cpBatiDataGridViewTextBoxColumn.HeaderText = "CpBati";
            cpBatiDataGridViewTextBoxColumn.Name = "cpBatiDataGridViewTextBoxColumn";
            cpBatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telBatiDataGridViewTextBoxColumn
            // 
            telBatiDataGridViewTextBoxColumn.DataPropertyName = "TelBati";
            telBatiDataGridViewTextBoxColumn.HeaderText = "TelBati";
            telBatiDataGridViewTextBoxColumn.Name = "telBatiDataGridViewTextBoxColumn";
            telBatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsableDataGridViewTextBoxColumn
            // 
            responsableDataGridViewTextBoxColumn.DataPropertyName = "Responsable";
            responsableDataGridViewTextBoxColumn.HeaderText = "Responsable";
            responsableDataGridViewTextBoxColumn.Name = "responsableDataGridViewTextBoxColumn";
            responsableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idVilleDataGridViewTextBoxColumn
            // 
            idVilleDataGridViewTextBoxColumn.DataPropertyName = "IdVille";
            idVilleDataGridViewTextBoxColumn.HeaderText = "IdVille";
            idVilleDataGridViewTextBoxColumn.Name = "idVilleDataGridViewTextBoxColumn";
            idVilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idVilleNavigationDataGridViewTextBoxColumn
            // 
            idVilleNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdVilleNavigation";
            idVilleNavigationDataGridViewTextBoxColumn.HeaderText = "IdVilleNavigation";
            idVilleNavigationDataGridViewTextBoxColumn.Name = "idVilleNavigationDataGridViewTextBoxColumn";
            idVilleNavigationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sallesDataGridViewTextBoxColumn
            // 
            sallesDataGridViewTextBoxColumn.DataPropertyName = "Salles";
            sallesDataGridViewTextBoxColumn.HeaderText = "Salles";
            sallesDataGridViewTextBoxColumn.Name = "sallesDataGridViewTextBoxColumn";
            sallesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batimentBindingSource
            // 
            batimentBindingSource.DataSource = typeof(Models.Batiment);
            batimentBindingSource.CurrentChanged += batimentBindingSource_CurrentChanged;
            // 
            // FBati
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBati);
            Name = "FBati";
            Text = "FBati";
            Load += FBati_Load;
            ((System.ComponentModel.ISupportInitialize)bsBati).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBati).EndInit();
            ((System.ComponentModel.ISupportInitialize)batimentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsBati;
        private DataGridView dgvBati;
        private DataGridViewTextBoxColumn idBatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomBatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anConstructionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rueBatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpBatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telBatiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn responsableDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idVilleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idVilleNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sallesDataGridViewTextBoxColumn;
        private BindingSource batimentBindingSource;
    }
}