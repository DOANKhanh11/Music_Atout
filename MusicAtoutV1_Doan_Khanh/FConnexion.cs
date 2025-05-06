using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using MusicAtoutV1_Doan_Khanh.Models;

namespace MusicAtoutV1_Doan_Khanh.Models
{

    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }

        private void FConnexion_Load(object sender, EventArgs e)
        {
            txtPasswd.PasswordChar = '*';
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string message = ModelProjet.validConnexion(txtUtilisateur.Text, txtPasswd.Text);

            if (ModelProjet.ConnexionValide)
            {
                if (ModelProjet.UtilisateurDoitChangerMotDePasse())
                {
                    MessageBox.Show("Votre compte a été réactivé ou créé, vous devez changer votre mot de passe.");
                    var formChangerMdp = new MusicAtoutV1_Doan_Khanh.FChangerMotDePasse();
                    formChangerMdp.ShowDialog();
                }
                else
                {
                    // Start FMenu in a new thread
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(message, "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ThreadProc()
        {
            Application.Run(new FMenu());
        }

        private void btnChangerMDP_Click(object sender, EventArgs e)
        {
             var formChangerMotDePasse = new MusicAtoutV1_Doan_Khanh.FChangerMotDePasse();
             formChangerMotDePasse.ShowDialog(); 
        }
    }
}
