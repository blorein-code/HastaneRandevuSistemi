using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        SqlBaglanti bgln = new SqlBaglanti();

        public string tc;

        private void SekreterDetayForm_Load(object sender, EventArgs e)
        {
            tcNoLabel.Text = tc;
            //TC'sine göre Sekreter ad soyad bilgilerini hasta detay ekranına getirdik.
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgln.baglanti());

            komut.Parameters.AddWithValue("@p1", tcNoLabel.Text);
            SqlDataReader reader = komut.ExecuteReader();


            while (reader.Read())
            {
                adSoyadLabel.Text = reader[0] + " ";
            }
            bgln.baglanti().Close();

            //Branşları Datagride Aktarma
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Branslarr",  bgln.baglanti());

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

            //Doktorları DataGrid'e alma

            DataTable doktorDataTable = new DataTable();
            //Doktor ad ve soyad colonu column1 şeklinde geldiği için column ismini doktorlar yaptık.
            SqlDataAdapter doktorDataAdapter = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans from Tbl_Doktorlar", bgln.baglanti());

            doktorDataAdapter.Fill(doktorDataTable);
            dataGridView2.DataSource = doktorDataTable;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void doktorPanel_Click(object sender, EventArgs e)
        {
            DoktorPanelForm doktorPanel = new DoktorPanelForm();
            //this.Hide();
            doktorPanel.Show();
        }

        private void bransPanel_Click(object sender, EventArgs e)
        {
            BransPanelForm bransPanel = new BransPanelForm();
           // this.Hide();
            bransPanel.Show();
        }

        private void randevuListe_Click(object sender, EventArgs e)
        {
            RandevuListeForm randevuPanel = new RandevuListeForm();
            //this.Hide();
            randevuPanel.Show();
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

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgln.baglanti());

            komutKaydet.Parameters.AddWithValue("@r1",tarihText.Text);
            komutKaydet.Parameters.AddWithValue("@r2",saatText.Text);
            komutKaydet.Parameters.AddWithValue("@r3", bransCombo.Text);
            komutKaydet.Parameters.AddWithValue("@r4",doktorCombo.Text);
            komutKaydet.ExecuteNonQuery();

            bgln.baglanti() .Close();
            MessageBox.Show("Randevu Oluşturulmuştur.");


        }

        private void olusturButon_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)",bgln.baglanti());

            komutEkle.Parameters.AddWithValue("@p1",duyuruText.Text);
            komutEkle.ExecuteNonQuery();

            bgln.baglanti().Close();

            MessageBox.Show("Duyuru Oluşturuldu.");

            duyuruText.Text = "";

        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            
        }

        private void duyuruBtn_Click(object sender, EventArgs e)
        {
            DuyurularForm duyurularForm = new DuyurularForm();
            duyurularForm.Show();
        }
    }
}
