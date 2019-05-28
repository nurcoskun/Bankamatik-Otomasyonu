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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
 SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        string x;
        public static string o;
        void getir()
        {

            string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = bağlantı;
            Baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM Musteriler order by M_No",Baglanti);
            SqlDataReader oku;
            oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (textBox1.Text == oku[0].ToString())
                {
                    if (textBox2.Text == oku[9].ToString())
                    {

                        o = oku[0].ToString();
                        x = oku[9].ToString();
                    }
                }
            }

            oku.Close();
            Baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            getir();
            if (textBox1.Text == o)
            {
                if (textBox2.Text == x)
                {
                    hesapbilgileri s = new hesapbilgileri();
                    s.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                    this.Hide();
                }
                if (textBox1.Text == o)
                {
                    MessageBox.Show("Müşteri Numaranız veya Şifreniz Yanlış");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                MessageBox.Show("Müşteri Numaranız veya Şifreniz Yanlış");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        
        

        private void giris_Load(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4;
            textBox1.MaxLength = 11;
            textBox2.PasswordChar = '*';
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
