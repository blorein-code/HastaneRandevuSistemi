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
    public partial class SekreterGirisForm : Form
    {
        public SekreterGirisForm()
        {
            InitializeComponent();
        }

        private void SekreterGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            SekreterDetayForm girisYapildi = new SekreterDetayForm();
            this.Hide();
            girisYapildi.Show();

        }
    }
}
