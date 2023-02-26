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
    public partial class DoktorDetayForm : Form
    {
        public DoktorDetayForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bilgiDuzenleButon_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenle bilgiDuzenle = new DoktorBilgiDuzenle();
            this.Hide();
            bilgiDuzenle.Show();
        }

        private void duyuruButon_Click(object sender, EventArgs e)
        {
            DuyurularForm duyuruForm = new DuyurularForm();
            this.Hide();
            duyuruForm.Show();
        }
    }
}
