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
    public partial class HastaBilgiDuzenle : Form
    {
        public HastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcNo;
        private void HastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            tcLabel.Text = tcNo;
        }
    }
}
