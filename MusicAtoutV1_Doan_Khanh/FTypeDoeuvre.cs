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
    public partial class FTypeDoeuvre : Form
    {
        public FTypeDoeuvre()
        {
            InitializeComponent();
        }

        private void FTypeDoeuvre_Load_1(object sender, EventArgs e)
        {
            bsTypeDoeuvre.DataSource = ModelProjet.listeTypeoeuvre();
            dgvTypeDoeuvre.DataSource = bsTypeDoeuvre;
        }

        private void dgvTypeDoeuvre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
