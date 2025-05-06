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
    public partial class FBati : Form
    {
        public FBati()
        {
            InitializeComponent();
        }

        private void batimentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FBati_Load(object sender, EventArgs e)
        {
            bsBati.DataSource = ModelProjet.listeTypeoeuvre();
            dgvBati.DataSource = bsBati;
        }
    }
}
