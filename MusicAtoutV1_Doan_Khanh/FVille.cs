using MusicAtoutV1_Doan_Khanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_Doan_Khanh
{
    public partial class FVille : Form
    {
        public FVille()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FVille_Load(object sender, EventArgs e)
        {
            bsVille.DataSource = ModelProjet.listeVille();
            dgvVille.DataSource = bsVille;

            if (dgvVille.Columns.Count > 2)
            {
                dgvVille.Columns[2].Visible = false; 
            }

            // Renommer les en-têtes des colonnes
            dgvVille.Columns[0].HeaderText = "N°Département"; 
            dgvVille.Columns[1].HeaderText = "Nom de la Ville"; 

        }
    }
}
