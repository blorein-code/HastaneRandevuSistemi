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
    public partial class HastaDetayForm : Form
    {
        public HastaDetayForm()
        {
            InitializeComponent();
        }

        public string tc;

        SqlBaglanti bgln = new SqlBaglanti();

        private void randevuAlButton_Click(object sender, EventArgs e)
        {
            SqlCommand randevuKomut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where RandevuId=@p3",bgln.baglanti());

            randevuKomut.Parameters.AddWithValue("@p1",tcLabel.Text);
            randevuKomut.Parameters.AddWithValue("@p2", sikayetText.Text);
            randevuKomut.Parameters.AddWithValue("@p3",idText.Text);

            randevuKomut.ExecuteNonQuery();
            bgln.baglanti().Close();

            MessageBox.Show("Randevu Alınmıştır.");

        }
        


        private void HastaDetayForm_Load(object sender, EventArgs e)
        {
            tcLabel.Text = tc;

            //TC'sine göre hasta ad soyad bilgilerini hasta detay ekranına getirdik.
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1", bgln.baglanti());

            komut.Parameters.AddWithValue("@p1", tcLabel.Text);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                adSoyadLabel.Text = reader[0] + " " + reader[1];
            }
            bgln.baglanti().Close();


            // Randevu Geçmişi Listeleme

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=+" + tc, bgln.baglanti());
            //Sorgudan gelen değerlerle dataAdapter'i doldur
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            //Branşları listeleme

            SqlCommand komutBrans = new SqlCommand("Select BransAd From Tbl_Branslarr", bgln.baglanti());

            SqlDataReader readerTwo = komutBrans.ExecuteReader();

            while (readerTwo.Read())
            {
                bransCombo.Items.Add(readerTwo[0]);
            }

            bgln.baglanti().Close();


        }

        private void doktorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Branş ve doktor seçildikten sonra bunlarla ilişkili olan randevular listelenecek

            DataTable randevuTable = new DataTable();
            SqlDataAdapter randevuDataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + bransCombo.Text + "'" + " and RandevuDoktor='" + doktorCombo.Text + "' and RandevuDurum=0", bgln.baglanti());

            randevuDataAdapter.Fill(randevuTable);

            dataGridView2.DataSource = randevuTable;

        }

        private void bransCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Branş seçimine göre ilgili doktorlar getirildi.

            doktorCombo.Items.Clear();

            SqlCommand komutDoldur = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgln.baglanti());

            komutDoldur.Parameters.AddWithValue("@p1", bransCombo.Text);


            SqlDataReader readerCombo = komutDoldur.ExecuteReader();

            while (readerCombo.Read())
            {
                doktorCombo.Items.Add(readerCombo[0] + " " + readerCombo[1]);
            }

            bgln.baglanti().Close();
        }

        private void bilgiLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaBilgiDuzenle hastaBilgiDuzenle = new HastaBilgiDuzenle();
            hastaBilgiDuzenle.tcNo = tcLabel.Text;
            hastaBilgiDuzenle.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            idText.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
