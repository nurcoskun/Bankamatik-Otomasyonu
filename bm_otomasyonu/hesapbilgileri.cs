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
    public partial class hesapbilgileri : Form
    {
        public hesapbilgileri()
        {
            InitializeComponent();
        }
        public string Tc;
        private void hesapbilgileri_Load(object sender, EventArgs e)
        {

            gster();
        }
        /*public void VeriGetir()
        {

            string baglantiCumlesi = "Server=.; database=banka; integrated security=SSPI";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);

            SqlCommand komut = new SqlCommand("Select * From Musteriler where Tc='" + Tc + "'", baglanti);
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
            oku.Read();

            label2.Text = "Hoşgeldiniz Sayın " + oku["Adsoyad"].ToString();
            label6.Text = oku["M_No"].ToString();
            label7.Text = oku["Adsoyad"].ToString();
            oku.Close();
          
        }*/

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
                    label6.Text = (datare[0].ToString());
                    label2.Text = "Sayın " + (datare[2].ToString()+" Hoşgeldiniz " );
                    label7.Text = (datare[2].ToString());
                }
            }
            datare.Close();
            Baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hesapislemleri frm = new hesapislemleri();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paracekme frm = new paracekme();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            giris frm = new giris();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parayatirma frm = new parayatirma();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bakiyesorma frm = new bakiyesorma();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paratransferi frm = new paratransferi();
            frm.Show();
            this.Hide();
        }

    }
}
