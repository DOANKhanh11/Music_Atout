using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MusicAtoutV1_Doan_Khanh.Models
{
    public static class ModelProjet
    {
        private static Sio2musicAtoutDoanContext monModel;

        public static Sio2musicAtoutDoanContext MonModel
        {
            get => monModel;
            set => monModel = value;
        }

        public static void init()
        {
            monModel = new Sio2musicAtoutDoanContext();
        }
        public static List<Ville> listeVille()
        {
            return monModel.Villes.ToList();
        }

        public static List<Salle> listeSalle()
        {
            return monModel.Salles.ToList();
        }

        public static List<Batiment> listeBatiment()
        {
            return monModel.Batiments.ToList();
        }

        public static List<Typeoeuvre> listeTypeoeuvre()
        {
            return monModel.Typeoeuvres.ToList();
        }

        public static List<Nationalite> listeNationalite()
        {
            return monModel.Nationalites.ToList();
        }

        public static List<Style> listeStyle()
        {
            return monModel.Styles.ToList();
        }

        public static List<Oeuvre> listOeuvre()
        {
            return monModel.Oeuvres.ToList();
        }

        public static List<Compositeur> listCompositeur()
        {
            return monModel.Compositeurs.ToList();
        }
        public static List<Utilisateur> listUtilisateur()
        {
            return monModel.Utilisateurs.ToList();
        }

        /*Ajouter, Modifier et Supprimer un compositeur */
        private static int actionGestionCompositeur;
        public static int ActionGestionCompositeur
        {
            get { return actionGestionCompositeur; }
            set { actionGestionCompositeur = value; }
        }


        private static Compositeur compositeurChoisi;
        public static Compositeur CompositeurChoisi
        {
            get { return compositeurChoisi; }
            set { compositeurChoisi = value; }
        }

        private static Compositeur idCompositeur;
        public static Compositeur GetCompositeurById(int idCompositeur)
        {
            return monModel.Compositeurs.SingleOrDefault(c => c.IdCompositeur == idCompositeur);
        }

        public static bool AjoutCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            try
            {
                compositeurChoisi = new Compositeur();
                compositeurChoisi.NomCompositeur = nom;
                compositeurChoisi.PrenomCompositeur = prenom;
                compositeurChoisi.Remarque = remarque;
                compositeurChoisi.AnNais = anNais;
                compositeurChoisi.AnMort = anMort;
                compositeurChoisi.IdNation = idNation;
                compositeurChoisi.IdStyle = idStyle;
                monModel.Compositeurs.Add(compositeurChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;

            try
            {
                    compositeurChoisi.NomCompositeur = nom;
                    compositeurChoisi.PrenomCompositeur = prenom;
                    compositeurChoisi.Remarque = remarque;
                    compositeurChoisi.AnNais = anNais;
                    compositeurChoisi.AnMort = anMort;
                    compositeurChoisi.IdNation = idNation;
                    compositeurChoisi.IdStyle = idStyle;
                    monModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
            }

            return vretour;
        }

        public static bool SuppCompositeur()
        {
            bool vretour = true;
            try
            {
                monModel.Compositeurs.Remove(compositeurChoisi);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                vretour = false;
                monModel.Dispose();
                init();
            }
            return vretour;
        }

        /*Pour l'utilisateur connect*/

        private static Utilisateur _utilisateurConnecte;
        public static Utilisateur utilisateurConnecte
        {
            get { return _utilisateurConnecte; }
            set { _utilisateurConnecte = value; }
        }
        private static bool connexionValide;
        public static bool ConnexionValide => connexionValide;

        public static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string validConnexion(string id, string mp)
        {
            string message = "";
            utilisateurConnecte = monModel.Utilisateurs.SingleOrDefault(u => u.IdUtilisateur == id);

            if (utilisateurConnecte == null)
            {
                message = "Identifiant incorrect.";
                return message;
            }

            if (utilisateurConnecte.Actif == null)
            {
                message = "Le compte n'est pas actif.";
                return message;
            }

            if (utilisateurConnecte.Passwd.Equals(GetMd5Hash(mp)))
            {
                connexionValide = true;
                utilisateurConnecte.Nbessais = 0; 
                monModel.SaveChanges();
                return message; 
            }
            else
            {
                utilisateurConnecte.Nbessais++;
                if (utilisateurConnecte.Nbessais >= 3)
                {
                    utilisateurConnecte.Actif = false;
                }
                monModel.SaveChanges();
                message = "Mot de passe incorrect.";
                return message;
            }
        }

        public static bool UtilisateurADesDroits(int droitsMinimums)
        {
            return ModelProjet.utilisateurConnecte.Droits >= droitsMinimums;
        }

        public static string ReactiverCompte(string idUtilisateurReactivateur, string idUtilisateurAReactiver)
        {
            var utilisateurReactivateur = monModel.Utilisateurs.SingleOrDefault(u => u.IdUtilisateur == idUtilisateurReactivateur);
            var utilisateurAReactiver = monModel.Utilisateurs.SingleOrDefault(u => u.IdUtilisateur == idUtilisateurAReactiver);

            if (utilisateurReactivateur == null || utilisateurAReactiver == null)
            {
                return "Utilisateur introuvable.";
            }

            // Vérifier le droit de l'utilisateur (2 ou plus) et le droit inférieur de l'utilisateur à réactiver
            if (utilisateurReactivateur.Droits >= 2 && utilisateurReactivateur.Droits >= utilisateurAReactiver.Droits)
            {
                utilisateurAReactiver.Actif = true;
                utilisateurAReactiver.Nbessais = 4;
                utilisateurAReactiver.Passwd = GetMd5Hash(utilisateurAReactiver.IdUtilisateur); // Réinitialisation du mot de passe

                monModel.SaveChanges();
                return $"Le compte de l'utilisateur {utilisateurAReactiver.IdUtilisateur} a été réactivé.";
            }
            else
            {
                return "Vous n'avez pas les droits pour réactiver cet utilisateur.";
            }
        }

        public static string DesactiverCompte(string idUtilisateurDesactivateur, string idUtilisateurADesactiver)
        {
            var utilisateurDesactivateur = monModel.Utilisateurs.SingleOrDefault(u => u.IdUtilisateur == idUtilisateurDesactivateur);
            var utilisateurADesactiver = monModel.Utilisateurs.SingleOrDefault(u => u.IdUtilisateur == idUtilisateurADesactiver);

            if (utilisateurDesactivateur == null || utilisateurADesactiver == null)
            {
                return "Utilisateur introuvable.";
            }

            // Vérifier si l'utilisateur a le droit 3
            if (utilisateurDesactivateur.Droits == 3)
            {
                utilisateurADesactiver.Actif = false;
                monModel.SaveChanges();
                return $"Le compte de l'utilisateur {utilisateurADesactiver.IdUtilisateur} a été désactivé.";
            }
            else
            {
                return "Vous n'avez pas les droits pour désactiver cet utilisateur.";
            }
        }

        public static string CreerUtilisateur(string idUtilisateurCreateur, string idUtilisateur, string nom, string droit)
        {
            var utilisateurCreateur = monModel.Utilisateurs.SingleOrDefault(u => u.IdUtilisateur == idUtilisateurCreateur);

            if (utilisateurCreateur == null)
            {
                return "Créateur introuvable.";
            }

            // Vérifier si l'utilisateur a le droit 3
            if (utilisateurCreateur.Droits == 3)
            {
                var nouvelUtilisateur = new Utilisateur
                {
                    IdUtilisateur = idUtilisateur,
                    Droits = Convert.ToInt32(droit),
                    Actif = true,
                    Nbessais = 4,
                    Passwd = GetMd5Hash(idUtilisateur) // Mot de passe temporaire
                };

                monModel.Utilisateurs.Add(nouvelUtilisateur);
                monModel.SaveChanges();
                return $"L'utilisateur {idUtilisateur} a été créé avec succès.";
            }
            else
            {
                return "Vous n'avez pas les droits pour créer un utilisateur.";
            }
        }

        public static bool EstMotDePasseTemporaire(string motDePasse, string idUtilisateur)
        {
            return GetMd5Hash(idUtilisateur).Equals(motDePasse);
        }

        public static bool ValiderNouveauMotDePasse(string motDePasse)
        {
            // Longueur minimale
            if (motDePasse.Length < 8)
            {
                return false;
            }

            // Vérifier la présence d'un chiffre
            if (!motDePasse.Any(char.IsDigit))
            {
                return false;
            }

            // Vérifier la présence d'un caractère spécial
            string caracteresSpeciaux = "()[]{}@ !$, ;:/";
            if (!motDePasse.Any(c => caracteresSpeciaux.Contains(c)))
            {
                return false;
            }

            return true;
        }

        public static bool UtilisateurDoitChangerMotDePasse()
        {
            string storedPasswordHash = utilisateurConnecte.Passwd;
            string expectedHash = GetMd5Hash(utilisateurConnecte.IdUtilisateur); // Mật khẩu mặc định

            bool doitChanger = storedPasswordHash == expectedHash || storedPasswordHash == "0x" + expectedHash;

            return doitChanger;
        }
    }
}
