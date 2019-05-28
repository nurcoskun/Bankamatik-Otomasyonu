using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace bm_otomasyonu
{
    public partial class bakiyesorma : Form
    {
        public bakiyesorma()
        {
            InitializeComponent();
        }

        void gster()
        {

            string hn = giris.o;


            string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = bağlantı;
            Baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM Musteriler order by M_No", Baglanti);
            SqlDataReader datare;

            datare = sorgu.ExecuteReader();
            while (datare.Read())
            {
                if (datare[0].ToString() == hn)
                {
                    textBox1.Text = (datare[10].ToString());
                    textBox2.Text = (datare[10].ToString());
                }
            }
            datare.Close();
            Baglanti.Close();
        }

        private void bakiyesorma_Load(object sender, EventArgs e)
        {
            gster();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            hesapbilgileri frm = new hesapbilgileri();
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
