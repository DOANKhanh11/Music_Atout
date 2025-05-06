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
    public partial class FCompositeurStyle : Form
    {
        public FCompositeurStyle()
        {
            InitializeComponent();
        }

        private void FCompositeurStyle_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "IdStyle";
            cboStyle.DisplayMember = "LibStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DataSource = bsStyle;
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            Style laStyleChoisie = (Style)bsStyle.Current;

            txtDebut.Text = laStyleChoisie.DateDebut.ToString();
            txtFin.Text = laStyleChoisie.DateFin.ToString();

            bsCompositeur.DataSource = laStyleChoisie.Compositeurs.Select(x => new { x.NomCompositeur, x.PrenomCompositeur, x.IdStyleNavigation.LibStyle, x.AnNais, x.AnMort, x.Remarque, x.IdCompositeur }).OrderBy(x => x.NomCompositeur).ToList();
            dgvCompositeur.DataSource = bsCompositeur;

            /*dgvCompositeur.Columns[0].Visible = false;
            dgvCompositeur.Columns[1].Visible = false;
            dgvCompositeur.Columns[2].Visible = false;
            dgvCompositeur.Columns[3].HeaderText = "Nom";
            dgvCompositeur.Columns[4].HeaderText = "Prénom";
            dgvCompositeur.Columns[5].HeaderText = "An Naissance";
            dgvCompositeur.Columns[6].HeaderText = "An Mort";
            dgvCompositeur.Columns[7].HeaderText = "Remarque";
            dgvCompositeur.Columns[8].Visible = false;
            dgvCompositeur.Columns[9].Visible = false;
            dgvCompositeur.Columns[10].Visible = false;*/

            dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FCompositeurStyle_Activated(object sender, EventArgs e)
        {
            bsStyle_CurrentChanged(this, new EventArgs());
        }
    }
}
