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
    public partial class BransPanelForm : Form
    {
        public BransPanelForm()
        {
            InitializeComponent();
        }

        SqlBaglanti bgln = new SqlBaglanti();

        private void BransPanelForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Branslarr", bgln.baglanti());

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            SqlCommand ekleKomut = new SqlCommand("insert into Tbl_Branslarr (BransAd) values (@p1)",bgln.baglanti());

            ekleKomut.Parameters.AddWithValue("@p1", bransAdText.Text);
            ekleKomut.ExecuteNonQuery();

            bgln.baglanti().Close();

            MessageBox.Show("Branş Eklendi");


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            bransIdText.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bransAdText.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();




        }

        private void silButon_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete from Tbl_Branslarr where BransId=@p1",bgln.baglanti());

            komutSil.Parameters.AddWithValue("@p1", bransIdText.Text);
            komutSil.ExecuteNonQuery();

            bgln.baglanti().Close();

            MessageBox.Show("Branş Silindi.");


        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            SqlCommand guncelleKomut = new SqlCommand("Update from Tbl_Branslarr set BransAd=@p1 where BransId=@p2",bgln.baglanti());

            guncelleKomut.Parameters.AddWithValue("@p1",bransAdText.Text);
            guncelleKomut.Parameters.AddWithValue("@p2", bransIdText.Text);
            guncelleKomut.ExecuteNonQuery();

            bgln.baglanti().Close();

            MessageBox.Show("Branş bilgisi güncellendi.");
        }
    }
}
