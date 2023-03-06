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
    public partial class DoktorDetayForm : Form
    {
        public DoktorDetayForm()
        {
            InitializeComponent();
        }
        public string tc;
        public string adSoyad;
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        SqlBaglanti bgln = new SqlBaglanti();

        private void bilgiDuzenleButon_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenle bilgiDuzenle = new DoktorBilgiDuzenle();
            bilgiDuzenle.tc = tcNoLabel.Text;
            //this.Hide();
            bilgiDuzenle.Show();
        }

        private void duyuruButon_Click(object sender, EventArgs e)
        {
            DuyurularForm duyuruForm = new DuyurularForm();
            
            duyuruForm.Show();


        }

        private void DoktorDetayForm_Load(object sender, EventArgs e)
        {
            tcNoLabel.Text = tc;
            adSoyadLabel.Text = adSoyad;



            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgln.baglanti());

            komut.Parameters.AddWithValue("@p1", tcNoLabel.Text);
            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                adSoyadLabel.Text = reader[0] + " " + reader[1];
            }
            bgln.baglanti().Close();

            //Randevular

            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + adSoyadLabel.Text+"'",bgln.baglanti());

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sikayetText.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
