using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Forme
{
    public partial class CinemaLogin : Form
    {
        public CinemaLogin()
        {
            InitializeComponent();
           // bunifuFlatButton1.BackColor = Color.Aqua;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1.Text = "AAAA";
            bunifuFlatButton1.Activecolor = Color.Aqua;
            bunifuFlatButton1.Normalcolor = Color.Aqua;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
