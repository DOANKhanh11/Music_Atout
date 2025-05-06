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
    public partial class FGestionUtilisateurs : Form
    {
        public FGestionUtilisateurs()
        {
            InitializeComponent();
            LoadUtilisateurs();
        }

        private void FGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            bsUtilisateur.DataSource = ModelProjet.listUtilisateur();
            dataGridViewUtilisateurs.DataSource = bsUtilisateur;

        }
        private void LoadUtilisateurs()
        {
            var utilisateurs = ModelProjet.MonModel.Utilisateurs.ToList();

            bsUtilisateur.DataSource = utilisateurs;

            var selectedUserId = GetSelectedUserId(); 

            if (!string.IsNullOrEmpty(selectedUserId))
            {
                var userToSelect = utilisateurs.FirstOrDefault(u => u.IdUtilisateur == selectedUserId);
                if (userToSelect != null)
                {
                    bsUtilisateur.Position = utilisateurs.IndexOf(userToSelect);
                }
            }

            dataGridViewUtilisateurs.DataSource = bsUtilisateur;
        }

        private string GetSelectedUserId()
        {
            var currentUtilisateur = bsUtilisateur.Current as Utilisateur;
            if (currentUtilisateur != null)
            {
                return currentUtilisateur.IdUtilisateur;
            }
            return null;
        }

        private void btnAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            if (ModelProjet.utilisateurConnecte.Droits < 3)
            {
                MessageBox.Show("Vous n'avez pas les droits pour créer un utilisateur.");
                return;
            }

            string idUtilisateur = txtIdUtilisateur.Text.Trim();
            string nom = txtNom.Text.Trim();
            string droit = cboDroits.SelectedItem.ToString().Split(' ')[0];

            string resultat = ModelProjet.CreerUtilisateur(ModelProjet.utilisateurConnecte.IdUtilisateur, idUtilisateur, nom, droit);
            MessageBox.Show(resultat, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadUtilisateurs();
        }

        private void btnReactiverCompte_Click(object sender, EventArgs e)
        {
            string idUtilisateurAReactiver = GetSelectedUserId(); 
            if (idUtilisateurAReactiver != null)
            {
                string resultat = ModelProjet.ReactiverCompte(ModelProjet.utilisateurConnecte.IdUtilisateur, idUtilisateurAReactiver);
                MessageBox.Show(resultat, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUtilisateurs(); 
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à réactiver.");
            }
        }


        private void btnDesactiverCompte_Click(object sender, EventArgs e)
        {
            string idUtilisateurADesactiver = GetSelectedUserId(); 
            if (idUtilisateurADesactiver != null)
            {
                string resultat = ModelProjet.DesactiverCompte(ModelProjet.utilisateurConnecte.IdUtilisateur, idUtilisateurADesactiver);
                MessageBox.Show(resultat, "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUtilisateurs(); 
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à désactiver.");
            }
        }
    }
}
