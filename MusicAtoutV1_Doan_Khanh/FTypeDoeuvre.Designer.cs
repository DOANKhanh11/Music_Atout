namespace MusicAtoutV1_Doan_Khanh
{
    partial class FTypeDoeuvre
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
            bsTypeDoeuvre = new BindingSource(components);
            dgvTypeDoeuvre = new DataGridView();
            idTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            libelleTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sallesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsTypeDoeuvre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTypeDoeuvre).BeginInit();
            SuspendLayout();
            // 
            // bsTypeDoeuvre
            // 
            bsTypeDoeuvre.DataSource = typeof(Models.Typeoeuvre);
            // 
            // dgvTypeDoeuvre
            // 
            dgvTypeDoeuvre.AllowUserToAddRows = false;
            dgvTypeDoeuvre.AllowUserToDeleteRows = false;
            dgvTypeDoeuvre.AutoGenerateColumns = false;
            dgvTypeDoeuvre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTypeDoeuvre.Columns.AddRange(new DataGridViewColumn[] { idTypeDataGridViewTextBoxColumn, libelleTypeDataGridViewTextBoxColumn, sallesDataGridViewTextBoxColumn });
            dgvTypeDoeuvre.DataSource = bsTypeDoeuvre;
            dgvTypeDoeuvre.Dock = DockStyle.Fill;
            dgvTypeDoeuvre.Location = new Point(0, 0);
            dgvTypeDoeuvre.Name = "dgvTypeDoeuvre";
            dgvTypeDoeuvre.ReadOnly = true;
            dgvTypeDoeuvre.Size = new Size(800, 450);
            dgvTypeDoeuvre.TabIndex = 0;
            dgvTypeDoeuvre.CellContentClick += dgvTypeDoeuvre_CellContentClick;
            // 
            // idTypeDataGridViewTextBoxColumn
            // 
            idTypeDataGridViewTextBoxColumn.DataPropertyName = "IdType";
            idTypeDataGridViewTextBoxColumn.HeaderText = "IdType";
            idTypeDataGridViewTextBoxColumn.Name = "idTypeDataGridViewTextBoxColumn";
            idTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleTypeDataGridViewTextBoxColumn
            // 
            libelleTypeDataGridViewTextBoxColumn.DataPropertyName = "LibelleType";
            libelleTypeDataGridViewTextBoxColumn.HeaderText = "LibelleType";
            libelleTypeDataGridViewTextBoxColumn.Name = "libelleTypeDataGridViewTextBoxColumn";
            libelleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sallesDataGridViewTextBoxColumn
            // 
            sallesDataGridViewTextBoxColumn.DataPropertyName = "Salles";
            sallesDataGridViewTextBoxColumn.HeaderText = "Salles";
            sallesDataGridViewTextBoxColumn.Name = "sallesDataGridViewTextBoxColumn";
            sallesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FTypeDoeuvre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTypeDoeuvre);
            Name = "FTypeDoeuvre";
            Text = "FTypeDoeuvre";
            Load += FTypeDoeuvre_Load_1;
            ((System.ComponentModel.ISupportInitialize)bsTypeDoeuvre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTypeDoeuvre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsTypeDoeuvre;
        private DataGridView dgvTypeDoeuvre;
        private DataGridViewTextBoxColumn idTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn libelleTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sallesDataGridViewTextBoxColumn;
    }
}