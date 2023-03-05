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
    public partial class HastaBilgiDuzenle : Form
    {
        public HastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcNo;

        SqlBaglanti bgln = new SqlBaglanti();
        private void HastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            tcLabel.Text = tcNo;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1",bgln.baglanti());

            komut.Parameters.AddWithValue("@p1",tcLabel.Text);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                hastaAdLabel.Text = reader[1].ToString();
                soyadLabel.Text = reader[2].ToString();
                telefonLabel.Text = reader[4].ToString();
                sifreLabel.Text = reader[5].ToString();
                cinsiyetCombo.Text = reader[6].ToString();
            }

            bgln.baglanti();

        }

        private void bilgiGuncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand bilgiGuncellendi = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgln.baglanti());

            bilgiGuncellendi.Parameters.AddWithValue("@p1",hastaAdLabel.Text);
            bilgiGuncellendi.Parameters.AddWithValue("@p2",soyadLabel.Text);
            bilgiGuncellendi.Parameters.AddWithValue("@p3",telefonLabel.Text);
            bilgiGuncellendi.Parameters.AddWithValue("@p4", sifreLabel.Text);
            bilgiGuncellendi.Parameters.AddWithValue("@p5", cinsiyetCombo.Text);
            bilgiGuncellendi.Parameters.AddWithValue("@p6",tcLabel.Text);

            bilgiGuncellendi.ExecuteNonQuery();

            bgln.baglanti().Close();

            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            this.Hide();
        
        
        }
    }
}
