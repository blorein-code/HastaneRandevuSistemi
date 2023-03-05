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
    public partial class DoktorPanelForm : Form
    {
        public DoktorPanelForm()
        {
            InitializeComponent();
        }

        SqlBaglanti bgln = new SqlBaglanti();

        private void DoktorPanelForm_Load(object sender, EventArgs e)
        {
            //Doktorları DataGrid'e alma

            DataTable doktorDataTable = new DataTable();
            //Doktor ad ve soyad colonu column1 şeklinde geldiği için column ismini doktorlar yaptık.
            SqlDataAdapter doktorDataAdapter = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgln.baglanti());

            doktorDataAdapter.Fill(doktorDataTable);
            dataGridView1.DataSource = doktorDataTable;
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            SqlCommand doktorEkle = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgln.baglanti());

            doktorEkle.Parameters.AddWithValue("@p1",adText.Text);
            doktorEkle.Parameters.AddWithValue("@p2",soyadText.Text);
            doktorEkle.Parameters.AddWithValue("@p3",bransCombo.Text);
            doktorEkle.Parameters.AddWithValue("@p4",tcText.Text);
            doktorEkle.Parameters.AddWithValue("@p5",sifreText.Text);

            doktorEkle.ExecuteNonQuery();

            bgln.baglanti().Close();

            MessageBox.Show("Yeni Doktor Eklendi.");

            


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            adText.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadText.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            bransCombo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tcText.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            sifreText.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void silButon_Click(object sender, EventArgs e)
        {
            SqlCommand doktorSil = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", bgln.baglanti());

            doktorSil.Parameters.AddWithValue("@p1", tcText.Text);
            doktorSil.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");



        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            SqlCommand bilgiGuncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgln.baglanti());

            bilgiGuncelle.Parameters.AddWithValue("@p1",adText.Text);
            bilgiGuncelle.Parameters.AddWithValue("@p2",soyadText.Text);
            bilgiGuncelle.Parameters.AddWithValue("@p3",bransCombo.Text);
            bilgiGuncelle.Parameters.AddWithValue("@p4",sifreText.Text);
            bilgiGuncelle.Parameters.AddWithValue("@p5",tcText.Text);

            bilgiGuncelle.ExecuteNonQuery();

            bgln.baglanti().Close();

            MessageBox.Show("Bilgiler Güncellendi.");


        }
    }
}
