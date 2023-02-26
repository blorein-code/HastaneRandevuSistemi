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
    public partial class SekreterDetayForm : Form
    {
        public SekreterDetayForm()
        {
            InitializeComponent();
        }

        private void SekreterDetayForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void doktorPanel_Click(object sender, EventArgs e)
        {
            DoktorPanelForm doktorPanel = new DoktorPanelForm();
            this.Hide();
            doktorPanel.Show();
        }

        private void bransPanel_Click(object sender, EventArgs e)
        {
            BransPanelForm bransPanel = new BransPanelForm();
            this.Hide();
            bransPanel.Show();
        }

        private void randevuListe_Click(object sender, EventArgs e)
        {
            RandevuListeForm randevuPanel = new RandevuListeForm();
            this.Hide();
            randevuPanel.Show();
        }
    }
}
