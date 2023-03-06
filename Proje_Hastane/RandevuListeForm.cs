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
    public partial class RandevuListeForm : Form
    {
        public RandevuListeForm()
        {
            InitializeComponent();
        }
        
        SqlBaglanti bgln = new SqlBaglanti();


        private void RandevuListeForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular",bgln.baglanti());

            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           secilen = dataGridView1.SelectedCells[0].RowIndex;

        }
    }
}
