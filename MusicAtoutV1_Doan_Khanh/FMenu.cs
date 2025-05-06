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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            if (ModelProjet.utilisateurConnecte.Droits < 2)
            {
                gestionDesUtilisateursToolStripMenuItem.Visible = false;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FVille formVille = new FVille();
            formVille.Show();
        }

        private void sALLESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FSalle formSalle = new FSalle();
            formSalle.Show();
        }

        private void bATIMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBati formBatiment = new FBati();
            formBatiment.Show();
        }

        private void tYPESDOEUVREToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FTypeDoeuvre formTypeOeuvre = new FTypeDoeuvre();
            formTypeOeuvre.Show();
        }

        private void parNationalitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurNation formCompositeurNation = new FCompositeurNation();
            formCompositeurNation.Show();
        }

        private void parToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurStyle formCompositeurStyle = new FCompositeurStyle();
            formCompositeurStyle.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            FConnexion connexionForm = new FConnexion();
            connexionForm.FormClosed += (s, args) => this.Close();
            connexionForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FGestionUtilisateurs gestionForm = new FGestionUtilisateurs();
            gestionForm.ShowDialog();
        }
    }
}
