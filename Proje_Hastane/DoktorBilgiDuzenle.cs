using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class DoktorBilgiDuzenle : Form
    {
        public DoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgln = new SqlBaglanti();
        public string tc;

        private void bilgiGuncelleButton_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",bgln.baglanti());


            komut.Parameters.AddWithValue("@p1", AdLabel.Text);
            komut.Parameters.AddWithValue("@p2", soyadLabel.Text);
            komut.Parameters.AddWithValue("@p3", bransCombo.Text);
            komut.Parameters.AddWithValue("@p4", sifreLabel.Text);
            komut.Parameters.AddWithValue("@p5", tcLabel.Text);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

            MessageBox.Show("Bilgiler güncellendi.");
        }

        private void DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            tcLabel.Text = tc;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1",bgln.baglanti());

            komut.Parameters.AddWithValue("@p1",tcLabel.Text);

            SqlDataReader dataReader = komut.ExecuteReader();
            while(dataReader.Read())
            {
                AdLabel.Text = dataReader[1].ToString();
                soyadLabel.Text = dataReader[2].ToString();
                bransCombo.Text = dataReader[3].ToString();
                sifreLabel.Text = dataReader[5].ToString();
            }

            bgln.baglanti().Close();

        }
    }
}
