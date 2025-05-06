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
    public partial class FSalle : Form
    {
        public FSalle()
        {
            InitializeComponent();
        }

        private void FSalle_Load_1(object sender, EventArgs e)
        {
            bsSalle.DataSource = ModelProjet.listeSalle();
            dgvSalle.DataSource = bsSalle;
        }
    }
}
