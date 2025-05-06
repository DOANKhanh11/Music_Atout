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
    public partial class FChangerMotDePasse : Form
    {
        public FChangerMotDePasse()
        {
            InitializeComponent();
        }

        private void FChangerMotDePasse_Load(object sender, EventArgs e)
        {

        }

        private void btnChangerMDP_Click(object sender, EventArgs e)
        {
            string ancienMotDePasse = txtAncienMDP.Text;
            string nouveauMotDePasse = txtNouveauMDP.Text;
            string confirmation = txtConfirmation.Text;

            string hashedInput = ModelProjet.GetMd5Hash(ancienMotDePasse);
            string hashedInputWith0x = "0x" + hashedInput;
            string storedHash = ModelProjet.utilisateurConnecte.Passwd;

            if (storedHash != hashedInput && storedHash != hashedInputWith0x)
            {
                MessageBox.Show("L'ancien mot de passe est incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier la confirmation
            if (nouveauMotDePasse != confirmation)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier règles de sécurité
            if (!ModelProjet.ValiderNouveauMotDePasse(nouveauMotDePasse))
            {
                MessageBox.Show(
                    "La modification du mot de passe doit respecter certaines règles de sécurité :\n" +
                    "• Longueur minimale (8 caractères),\n" +
                    "• Présence de caractères spécifiques : ()[]{}@ !$, ;:/,\n" +
                    "• Contenir au moins un chiffre.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Hash mot de passe et sauvegarde
            string nouveauHash = ModelProjet.GetMd5Hash(nouveauMotDePasse);
            ModelProjet.utilisateurConnecte.Passwd = nouveauHash;
            ModelProjet.utilisateurConnecte.Nbessais = 4;
            ModelProjet.MonModel.SaveChanges();

            MessageBox.Show("Mot de passe modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
