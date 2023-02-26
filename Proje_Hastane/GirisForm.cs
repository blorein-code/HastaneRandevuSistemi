using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGirisForm doktorGiris = new DoktorGirisForm();
            doktorGiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SekreterGirisForm sekreterGiris = new SekreterGirisForm();
            sekreterGiris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGirisForm hastaGiris = new HastaGirisForm();
            hastaGiris.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
