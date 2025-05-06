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
    public partial class FOeuvre : Form
    {
        public FOeuvre()
        {
            InitializeComponent();
        }

        private void FOeuvre_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DataSource = bsStyle;

        }


        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {

            Style laStyleChoisie = (Style)bsStyle.Current;

            txtDebut.Text = laStyleChoisie.DateDebut.HasValue ? laStyleChoisie.DateDebut.Value.ToString() : "N/A";
            txtFin.Text = laStyleChoisie.DateFin.HasValue ? laStyleChoisie.DateFin.Value.ToString() : "N/A";

            bsCompositeur.DataSource = laStyleChoisie.Compositeurs.ToList(); ;
            dgvCompositeur.DataSource = bsCompositeur;

            dgvCompositeur.Columns[0].Visible = false;
            dgvCompositeur.Columns[1].Visible = false;
            dgvCompositeur.Columns[2].Visible = false;
            dgvCompositeur.Columns[3].HeaderText = "Nom";
            dgvCompositeur.Columns[4].HeaderText = "Prénom";
            dgvCompositeur.Columns[5].Visible = false;
            dgvCompositeur.Columns[6].Visible = false;
            dgvCompositeur.Columns[7].Visible = false;
            dgvCompositeur.Columns[8].Visible = false;
            dgvCompositeur.Columns[9].Visible = false;
            dgvCompositeur.Columns[10].Visible = false;
            dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void bsCompositeur_CurrentChanged_1(object sender, EventArgs e)
        {
            Compositeur leCompositeurChoisie = (Compositeur)bsCompositeur.Current;

            txtCompositeur.Text = leCompositeurChoisie.PrenomCompositeur + leCompositeurChoisie.NomCompositeur;
            txtNationalite.Text = leCompositeurChoisie.IdNationNavigation.LibNation;
            txtStyle.Text = leCompositeurChoisie.IdStyleNavigation.LibStyle;
            txtNaissance.Text = leCompositeurChoisie.AnNais.ToString();
            txtDeces.Text = leCompositeurChoisie.AnMort.ToString();
            txtInfo.Text = leCompositeurChoisie.Remarque.ToString();

            dgvOeuvre.DataSource = leCompositeurChoisie.Oeuvres.ToList();

            dgvOeuvre.Columns[0].Visible = false;
            dgvOeuvre.Columns[1].Visible = false;
            dgvOeuvre.Columns[2].Visible = false;
            dgvOeuvre.Columns[3].HeaderText = "Oeuvre";
            dgvOeuvre.Columns[4].HeaderText = "Composition";
            dgvOeuvre.Columns[5].Visible = false;
            dgvOeuvre.Columns[6].Visible = false;
            dgvOeuvre.Columns[7].Visible = false;
        }

        private void dgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
