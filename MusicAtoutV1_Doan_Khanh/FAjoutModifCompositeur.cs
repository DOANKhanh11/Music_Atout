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
    public partial class FAjoutModifCompositeur : Form
    {
        public FAjoutModifCompositeur()
        {
            InitializeComponent();
        }

        private void FAjoutModifCompositeur_Load(object sender, EventArgs e)
        {
            cboNation.ValueMember = "idNation";
            cboNation.DisplayMember = "libNation";
            cboStyle.ValueMember = "idStyle";
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DataSource = bsStyle;
            bsNation.DataSource = ModelProjet.listeNationalite();
            cboNation.DataSource = bsNation;

            if (ModelProjet.ActionGestionCompositeur == 2 && ModelProjet.CompositeurChoisi != null)
            {

                txtNom.Text = ModelProjet.CompositeurChoisi.NomCompositeur;
                txtPrenom.Text = ModelProjet.CompositeurChoisi.PrenomCompositeur;
                txtAnNais.Text = ModelProjet.CompositeurChoisi.AnNais.ToString();
                txtAnMort.Text = ModelProjet.CompositeurChoisi.AnMort.ToString();
                txtRemarque.Text = ModelProjet.CompositeurChoisi.Remarque;


                cboNation.SelectedValue = ModelProjet.CompositeurChoisi.IdNation;
                cboStyle.SelectedValue = ModelProjet.CompositeurChoisi.IdStyle;
            }
            else
            {
                txtNom.Clear();
                txtPrenom.Clear();
                txtAnNais.Clear();
                txtAnMort.Clear();
                txtRemarque.Clear();
                cboNation.SelectedIndex = -1;
                cboStyle.SelectedIndex = -1;
            }
        }


        private void bsCompositeur_CurrentChanged(object sender, EventArgs e)
        {
            System.Type type = bsCompositeur.Current.GetType();
            int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompositeur.Current, null);

            Compositeur compositeur = ModelProjet.GetCompositeurById(id);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tests())
            {
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string remarque = txtRemarque.Text;
                int anNais = int.Parse(txtAnNais.Text);
                int anMort = string.IsNullOrEmpty(txtAnMort.Text) ? 0 : int.Parse(txtAnMort.Text);
                int idNation = (int)cboNation.SelectedValue;
                int idStyle = (int)cboStyle.SelectedValue;

                bool success = false;

                if (ModelProjet.ActionGestionCompositeur == 1)
                {
                    success = ModelProjet.AjoutCompositeur(nom, prenom, remarque, anNais, anMort, idNation, idStyle);
                }
                else if (ModelProjet.ActionGestionCompositeur == 2)
                {
                    success = ModelProjet.ModifCompositeur(nom, prenom, remarque, anNais, anMort, idNation, idStyle);
                }

                if (success)
                {
                    if (ModelProjet.ActionGestionCompositeur == 1)
                    {
                        MessageBox.Show("Compositeur ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (ModelProjet.ActionGestionCompositeur == 2)
                    {
                        MessageBox.Show("Compositeur modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'opération.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void afficheErreur(List<string> erreurs)
        {
            StringBuilder message = new StringBuilder("Veuillez corriger les erreurs suivants: \n\n");
            foreach (string erreur in erreurs)
            {
                message.Append("\u25C9\t" + erreur + "\n");
            }
            MessageBox.Show(message.ToString(), "Erreurs de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool tests()
        {
            bool vretour = true;
            errorProvider1.Clear();
            List<string> erreurs = new List<string>();

            //
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                erreurs.Add("Le nom du compositeur doit être renseigné.");
                vretour = false;
            }

            if (string.IsNullOrEmpty(txtPrenom.Text))
            {
                erreurs.Add("Le prenom du compositeur doit être renseigné.");
                vretour = false;
            }
            //La textbox An Naiss est remplie avec un entier compris entre 500 et l’année du jour -15,
            if (!int.TryParse(txtAnNais.Text, out int anNais) || anNais < 500 || anNais > DateTime.Now.Year - 15)
            {
                erreurs.Add("L'année de naissance doit être un entier entre 500 et l'année actuelle - 15.");
                vretour = false;
            }
            // Si la textbox An Mort est remplie, l’entier est supérieur à la date de naissance+15 et inférieure à la date de naissance + 125 et inférieure ou égale à l’année du jour
            if (!string.IsNullOrEmpty(txtAnMort.Text) && (!int.TryParse(txtAnMort.Text, out int anMort) || anMort < anNais + 15 || anMort > anNais + 125 || anMort > DateTime.Now.Year))
            {
                erreurs.Add("L'année de mort doit être valide et supérieure à l'année de naissance + 15.");
                vretour = false;
            }

            if (string.IsNullOrEmpty(txtRemarque.Text))
            {
                erreurs.Add("La remarque doit être renseignée.");
                vretour = false;
            }
            if (erreurs.Count > 0)
            {
                afficheErreur(erreurs);
            }

            return vretour;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
