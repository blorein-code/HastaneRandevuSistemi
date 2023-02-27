using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class HastaKayitForm : Form
    {
        public HastaKayitForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut =  new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6) ", sqlBaglanti.baglanti());

            komut.Parameters.AddWithValue("@p1",hastaAdLabel.Text);
            komut.Parameters.AddWithValue("@p2", soyadLabel.Text);
            komut.Parameters.AddWithValue("@p3", tcLabel.Text);
            komut.Parameters.AddWithValue("@p4", telefonLabel.Text);
            komut.Parameters.AddWithValue("@p5", sifreLabel.Text);
            komut.Parameters.AddWithValue("@p6", cinsiyetCombo.Text);

            komut.ExecuteNonQuery();
            sqlBaglanti.baglanti().Close();

            MessageBox.Show("Başarıyla Kayıt Olundu");
            this.Hide();
            HastaGirisForm hastaKayitTamam = new HastaGirisForm();
            hastaKayitTamam.Show();
        }
    }
}
