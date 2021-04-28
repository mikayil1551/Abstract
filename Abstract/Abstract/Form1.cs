using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGitar_Click(object sender, EventArgs e)
        {
            Gitar gtr = new Gitar();
            MuzikAletiCal(gtr);
        }

        private void btnKeman_Click(object sender, EventArgs e)
        {
            Keman kmn = new Keman();
            MuzikAletiCal(kmn);
 
        }

        private void btnBateri_Click(object sender, EventArgs e)
        {
            Bateri btr = new Bateri();
            MuzikAletiCal(btr);
        }

        private void btnMac_Click(object sender, EventArgs e)
        {

        }
        private void MuzikAletiCal(MuzikAletleri ma)
        {
            MessageBox.Show(ma.Cal());
        }
    }
}
