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
    public partial class DoktorGirisForm : Form
    {
        public DoktorGirisForm()
        {
            InitializeComponent();
        }

        SqlBaglanti bgln = new SqlBaglanti();
        
        private void girisYapButton_Click(object sender, EventArgs e)
        {

            SqlCommand girisYap = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1 and DoktorSifre=@p2", bgln.baglanti());
            girisYap.Parameters.AddWithValue("@p1", tcNoLabel.Text);
            girisYap.Parameters.AddWithValue("@p2", sifreLabel.Text);
            SqlDataReader reader = girisYap.ExecuteReader();

            if (reader.Read())
            {
                DoktorDetayForm girisYapildi = new DoktorDetayForm();
                girisYapildi.tc = tcNoLabel.Text;
                

                girisYapildi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen bilgiler hatalı!");
            }

            bgln.baglanti().Close();


            
            
            
            
        }

        private void DoktorGirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
