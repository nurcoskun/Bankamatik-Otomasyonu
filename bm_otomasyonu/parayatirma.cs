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
    public partial class parayatirma : Form
    {
        public parayatirma()
        {
            InitializeComponent();
        }

        private void parayatirma_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            radioButton1.Checked = true;
        }

        string x;
        void getr()
        {
            string hn = giris.o;
            string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = bağlantı;
            Baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM Musteriler order by Bakiye", Baglanti);
            SqlDataReader oku;
            oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku[0].ToString() == hn)
                {
                    x = oku[10].ToString();
                }
            }
            Baglanti.Close();
            oku.Close();
        }
        void getir()
        {
            //string hn = giris.o;

           

                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                        string  sorgu;
                string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = bağlantı;
                //Baglanti.Open();
                sorgu = "Update Musteriler set [Bakiye]=Bakiye+" + Convert.ToInt64(textBox1.Text) + "where M_No='" + giris.o + "'";
                SqlCommand a = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                a.ExecuteNonQuery();
                Baglanti.Close();

                MessageBox.Show("Hesabınıza " + textBox1.Text.ToString() + " TL Yatırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb6ekle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            

        void rb1getir()
        {
            //string hn = giris.o;

                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {

                        string sorgu;
                string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = bağlantı;
                sorgu = "Update Musteriler set [Bakiye]=Bakiye+" + Convert.ToInt32(radioButton1.Text) + " where M_No='" + giris.o + "'";
                SqlCommand a = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                a.ExecuteNonQuery();
                Baglanti.Close();

                MessageBox.Show("Hesaba " + radioButton1.Text.ToString() + " TL Yatırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb1ekle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        void rb2getir()
        {
            //string hn = giris.o;


                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                        string sorgu;
                string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = bağlantı;
                sorgu = "Update Musteriler set [Bakiye]=Bakiye+" + Convert.ToInt32(radioButton2.Text) + " where M_No='" + giris.o + "'";
                SqlCommand a = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                a.ExecuteNonQuery();
                Baglanti.Close();

                MessageBox.Show("Hesaba " + radioButton2.Text.ToString() + " TL Yatırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb2ekle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        void rb3getir()
        {
            //string hn = giris.o;


                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                string sorgu;
                string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = bağlantı;
                sorgu = "Update Musteriler set [Bakiye]=Bakiye+" + Convert.ToInt32(radioButton3.Text) + " where M_No='" + giris.o + "'";
                SqlCommand a = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                a.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Hesaba " + radioButton3.Text.ToString() + " TL Yatırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb3ekle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
        void rb4getir()
        {
            //string hn = giris.o;


                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                string sorgu;
                string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = bağlantı;
                sorgu = "Update Musteriler set [Bakiye]=Bakiye+" + Convert.ToInt32(radioButton4.Text) + " where M_No='" + giris.o + "'";
                SqlCommand a = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                a.ExecuteNonQuery();
                Baglanti.Close();

                MessageBox.Show("Hesaba " + radioButton4.Text.ToString() + " TL Yatırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb4ekle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        void rb5getir()
        {
            //string hn = giris.o;


                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                string sorgu;
                string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                SqlConnection Baglanti = new SqlConnection();
                Baglanti.ConnectionString = bağlantı;
                sorgu = "Update Musteriler set [Bakiye]=Bakiye+" + Convert.ToInt32(radioButton5.Text) + " where M_No='" + giris.o + "'";
                SqlCommand a = new SqlCommand(sorgu, Baglanti);
                Baglanti.Open();
                a.ExecuteNonQuery();
                Baglanti.Close();

                MessageBox.Show("Hesaba " + radioButton5.Text.ToString() + " TL Yatırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        rb5ekle();
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            

        

        private void button2_Click(object sender, EventArgs e)
        {
            hesapbilgileri frm = new hesapbilgileri();
            frm.Show();
            this.Hide();
        }




        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {

                textBox1.Visible = true;
                label1.Visible = true;
                label4.Visible = true;
            }
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

                textBox1.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                textBox1.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {

                textBox1.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {

                textBox1.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {

                textBox1.Visible = false;
                label1.Visible = false;
                label4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                rb1getir();
                getr();

            }
            else if (radioButton2.Checked == true)
            {
                rb2getir();
                getr();
            }
            else if (radioButton3.Checked == true)
            {
                rb3getir();
                getr();
            }
            else if (radioButton4.Checked == true)
            {
                rb4getir();
                getr();
            }
            else if (radioButton5.Checked == true)
            {
                rb5getir();
                getr();
            }
            else if (radioButton6.Checked == true)
            {
                getr();
                getir();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("En az bir seçim yapmalısınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void rb1ekle()
        {

            string con, command;



            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();

            command = "insert into hareketler(M_No,IslemAdi,Tutar,Tarih) values (@mno,@islemadi,@tutar,@tarih)";

            SqlConnection bag = new SqlConnection(baglanti);
            SqlCommand a = new SqlCommand(command, bag);
            bag.Open();
            a.Parameters.AddWithValue("@mno", giris.o);
            a.Parameters.AddWithValue("@islemadi", "Para Yatırma");
            a.Parameters.AddWithValue("@tutar", radioButton1.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
        void rb2ekle()
        {

            string con, command;



            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();

            command = "insert into hareketler(M_No,IslemAdi,Tutar,Tarih) values (@mno,@islemadi,@tutar,@tarih)";

            SqlConnection bag = new SqlConnection(baglanti);
            SqlCommand a = new SqlCommand(command, bag);
            bag.Open();
            a.Parameters.AddWithValue("@mno", giris.o);
            a.Parameters.AddWithValue("@islemadi", "Para Yatırma");
            a.Parameters.AddWithValue("@tutar", radioButton2.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
        void rb3ekle()
        {

            string con, command;



            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();

            command = "insert into hareketler(M_No,IslemAdi,Tutar,Tarih) values (@mno,@islemadi,@tutar,@tarih)";

            SqlConnection bag = new SqlConnection(baglanti);
            SqlCommand a = new SqlCommand(command, bag);
            bag.Open();
            a.Parameters.AddWithValue("@mno", giris.o);
            a.Parameters.AddWithValue("@islemadi", "Para Yatırma");
            a.Parameters.AddWithValue("@tutar", radioButton3.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
        void rb4ekle()
        {

            string con, command;



            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();

            command = "insert into hareketler(M_No,IslemAdi,Tutar,Tarih) values (@mno,@islemadi,@tutar,@tarih)";

            SqlConnection bag = new SqlConnection(baglanti);
            SqlCommand a = new SqlCommand(command, bag);
            bag.Open();
            a.Parameters.AddWithValue("@mno", giris.o);
            a.Parameters.AddWithValue("@islemadi", "Para Yatırma");
            a.Parameters.AddWithValue("@tutar", radioButton4.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
        void rb5ekle()
        {

            string con, command;



            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();

            command = "insert into hareketler(M_No,IslemAdi,Tutar,Tarih) values (@mno,@islemadi,@tutar,@tarih)";

            SqlConnection bag = new SqlConnection(baglanti);
            SqlCommand a = new SqlCommand(command, bag);
            bag.Open();
            a.Parameters.AddWithValue("@mno", giris.o);
            a.Parameters.AddWithValue("@islemadi", "Para Yatırma");
            a.Parameters.AddWithValue("@tutar", radioButton5.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
        void rb6ekle()
        {

            string con, command;



            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();

            command = "insert into hareketler(M_No,IslemAdi,Tutar,Tarih) values (@mno,@islemadi,@tutar,@tarih)";

            SqlConnection bag = new SqlConnection(baglanti);
            SqlCommand a = new SqlCommand(command, bag);
            bag.Open();
            a.Parameters.AddWithValue("@mno", giris.o);
            a.Parameters.AddWithValue("@islemadi", "Para Yatırma");
            a.Parameters.AddWithValue("@tutar", textBox1.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
    }
}
