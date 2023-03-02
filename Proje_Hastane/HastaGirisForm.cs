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
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class HastaGirisForm : Form
    {
        public HastaGirisForm()
        {
            InitializeComponent();
        }

        private void HastaGirisForm_Load(object sender, EventArgs e)
        {

        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand girisYap = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", sqlBaglanti.baglanti());
            girisYap.Parameters.AddWithValue("@p1", tcNoLabel.Text);
            girisYap.Parameters.AddWithValue("@p2", sifreLabel.Text);
            SqlDataReader reader = girisYap.ExecuteReader();

            if (reader.Read())
            {
                HastaDetayForm girisBasarili = new HastaDetayForm();
                girisBasarili.tc = tcNoLabel.Text;

                girisBasarili.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen bilgiler hatalı!");
            }

            sqlBaglanti.baglanti().Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaKayitForm hastaKayit = new HastaKayitForm();
            hastaKayit.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
