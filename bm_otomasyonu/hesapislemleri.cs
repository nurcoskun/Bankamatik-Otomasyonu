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
    public partial class hesapislemleri : Form
    {
        public hesapislemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hesapbilgileri frm = new hesapbilgileri();
            frm.Show();
            this.Hide();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       // SqlConnection conn = new SqlConnection("Server=.; Initial Catalog=banka;Integrated Security=SSPI");


        string x;
        void getr()
        {
            string hn = giris.o;

            string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = bağlantı;
            Baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM Musteriler order by Sifre", Baglanti);
            SqlDataReader oku;
            oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku[0].ToString() == hn)
                {
                    x = oku[9].ToString();
                }
            }
            Baglanti.Close();
            oku.Close();
        }


        void getir()
        {
            string hn = giris.o;

            if (textBox1.Text == textBox4.Text & textBox3.Text == x)
            {
                DialogResult onay = new DialogResult();
                onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    string sorgu;

                    string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                    SqlConnection Baglanti = new SqlConnection();
                    Baglanti.ConnectionString = bağlantı;
                    Baglanti.Open();

                    sorgu = "Update Musteriler set [Sifre]='" + textBox4.Text + "' where M_No='" + hn + "'";
                    SqlConnection bağlan = new SqlConnection(bağlantı);
                    SqlCommand a = new SqlCommand(sorgu, bağlan);
                    bağlan.Open();
                    a.ExecuteNonQuery();
                    bağlan.Close();
                    MessageBox.Show("İşlem Gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sifre_ekle();
                }
                else {
                    MessageBox.Show("İşlem İptal Edildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mevcut şifre doğru değil yada şifreler uyuşmuyor");

            }
        }
        void sifre_ekle()
        {

            string command;



            string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
           SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = bağlantı;
           

            command = "insert into hareketler(M_No,IslemAdi,Tarih) values (@mno,@islemadi,@tarih)";

            SqlConnection bag = new SqlConnection(bağlantı);
            SqlCommand a = new SqlCommand(command, bag);
            bag.Open();
            a.Parameters.AddWithValue("@mno", giris.o);
            a.Parameters.AddWithValue("@islemadi", "Şifre Yenileme");
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            getr();
            getir();
            textBox1.Clear();
            textBox4.Clear();
            textBox3.Clear();

        }

        private void hesapislemleri_Load(object sender, EventArgs e)
        {
            textBox4.MaxLength = 4;
            textBox4.PasswordChar = '*';
            textBox3.MaxLength = 4;
            textBox3.PasswordChar = '*';
            textBox1.MaxLength = 4;
            textBox1.PasswordChar = '#';
            hesapislemleri_goster();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void hesapislemleri_goster()
           
        { string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = bağlantı;
               
            try
            {

                
                Baglanti.Open();

                SqlCommand cmd = new SqlCommand("select M_No as [HESAP NUMARASI],IslemAdi as[İŞLEM ADI],Tutar as[TUTAR],tarih as[TARİH] from hareketler  where M_No='" + giris.o + "'ORDER BY tarih ASC", Baglanti);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                adp.Fill(table);
                dataGridView1.DataSource = table;
                Baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Bankamatik Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Baglanti.Close();
            }

        }


    }
}
