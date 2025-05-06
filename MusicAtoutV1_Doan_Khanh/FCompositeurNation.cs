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
    public partial class FCompositeurNation : Form
    {
        public FCompositeurNation()
        {
            InitializeComponent();
            button1.BackColor = Color.Red;
            cboNation.Enabled = true;
        }


        private void FCompositeurNation_Load(object sender, EventArgs e)
        {
            cboNation.ValueMember = "idNation";
            cboNation.DisplayMember = "libNation";
            bsNation.DataSource = ModelProjet.listeNationalite();
            cboNation.DataSource = bsNation;
        }

        private void bsNation_CurrentChanged(object sender, EventArgs e)
        {
            Nationalite laNationaliteChoisie = (Nationalite)bsNation.Current;
            bsCompositeur.DataSource = laNationaliteChoisie.Compositeurs.Select(x => new { x.NomCompositeur, x.PrenomCompositeur, x.IdStyleNavigation.LibStyle, x.AnNais, x.AnMort, x.Remarque, x.IdCompositeur }).OrderBy(x => x.NomCompositeur).ToList();
            dgvCompositeur.DataSource = bsCompositeur;
            dgvCompositeur.Columns[0].HeaderText = "NOM";
            dgvCompositeur.Columns[1].HeaderText = "PRENOM";
            dgvCompositeur.Columns[2].HeaderText = "STYLE";
            dgvCompositeur.Columns[3].HeaderText = "Né le";
            dgvCompositeur.Columns[4].HeaderText = "Mort le";
            dgvCompositeur.Columns[5].HeaderText = "Informations";
            dgvCompositeur.Columns[6].Visible = false;
            dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 1)
            {
                button1.BackColor = Color.Green;
                cboNation.Enabled = false;
            }
            else
            {
                button1.BackColor = Color.Red;
                cboNation.Enabled = true;
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            ModelProjet.ActionGestionCompositeur = 1;
            ModelProjet.CompositeurChoisi = null;
            FAjoutModifCompositeur formAjout = new FAjoutModifCompositeur();
            formAjout.ShowDialog();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            ModelProjet.ActionGestionCompositeur = 2;
            System.Type type = bsCompositeur.Current.GetType();
            //int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompositeur.Current, null);
            var currentCompositeur = bsCompositeur.Current;
            int id = (int)currentCompositeur.GetType().GetProperty("IdCompositeur").GetValue(currentCompositeur, null);
            ModelProjet.CompositeurChoisi = ModelProjet.GetCompositeurById(id);
            FAjoutModifCompositeur formModif = new FAjoutModifCompositeur();
            formModif.ShowDialog();
        }

        private void FCompositeurNation_Activated(object sender, EventArgs e)
        {
            bsNation_CurrentChanged(this, new EventArgs());
        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            var currentCompositeur = bsCompositeur.Current;
            int id = (int)currentCompositeur.GetType().GetProperty("IdCompositeur").GetValue(currentCompositeur, null);
            ModelProjet.CompositeurChoisi = ModelProjet.GetCompositeurById(id);

            if (ModelProjet.CompositeurChoisi == null)
            {
                MessageBox.Show("Veuillez sélectionner un compositeur à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer le compositeur : "
                + ModelProjet.CompositeurChoisi.PrenomCompositeur.Trim() + " - "
                + ModelProjet.CompositeurChoisi.NomCompositeur.Trim(), "Suppression",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool success = ModelProjet.SuppCompositeur();

                if (success)
                {
                    MessageBox.Show("Compositeur supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du compositeur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bsCompositeur_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
