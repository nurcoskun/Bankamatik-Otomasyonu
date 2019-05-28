using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections; 

namespace bm_otomasyonu
{
    public partial class paracekme : Form
    {
        public paracekme()
        {
            InitializeComponent();
        }


       
        private void paracekme_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label4.Visible = false;
            label1.Visible = false;

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

        private void button2_Click(object sender, EventArgs e)
        {
            hesapbilgileri frm = new hesapbilgileri();
            frm.Show();
            this.Hide();
        }
        SqlConnection con;
        SqlCommand cmd;

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


            string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = bağlantı;
            Baglanti.Open();
            SqlCommand sorgu1 = new SqlCommand ("select Bakiye from Musteriler Where M_No='"+giris.o+"'",Baglanti);
            int girilentutar = Convert.ToInt32(textBox1.Text);
            SqlDataReader rdr = sorgu1.ExecuteReader();

            while (rdr.Read())
            {

                int hesaptakitutar = Convert.ToInt32(rdr["Bakiye"]);

                if (hesaptakitutar > girilentutar)
                {
                    DialogResult onay=new DialogResult();
                    onay=MessageBox.Show("İşlemi Onaylıyor Musunuz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                    string  sorgu;
                        string con = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                        SqlConnection Baglanti1 = new SqlConnection();
                        Baglanti1.ConnectionString = con;
                        //Baglanti1.Open();
                        sorgu = "Update Musteriler set [Bakiye]=Bakiye-" + Convert.ToInt64(textBox1.Text) + "where M_No='" + giris.o + "'";
                   // SqlConnection bağlan = new SqlConnection(bağlantı);
                    SqlCommand a = new SqlCommand(sorgu, Baglanti1);
                    Baglanti1.Open();
                    a.ExecuteNonQuery();
                    Baglanti1.Close();
                   
                        MessageBox.Show("Hesaptan " + textBox1.Text.ToString() + " TL Çekildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb6ekle();
                    }
                    else {
                        MessageBox.Show("İşlem iptal edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Baglanti.Close();
            rdr.Close();
        }
        void rb1getir()
        {
            //string hn = giris.o;


            string bağlantı = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = bağlantı;
            Baglanti.Open();
            SqlCommand sorgu1 = new SqlCommand("select Bakiye from Musteriler Where M_No='" + giris.o + "'", Baglanti);
            int girilentutar = Convert.ToInt32(radioButton1.Text); 
            SqlDataReader rdr = sorgu1.ExecuteReader();

            while (rdr.Read())
            {

                int hesaptakitutar = Convert.ToInt32(rdr["Bakiye"].ToString());

                if (hesaptakitutar > girilentutar)
                { 
                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {

                    string sorgu;
                        string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                        SqlConnection Baglanti1 = new SqlConnection();
                        Baglanti1.ConnectionString = baglanti;
                       // Baglanti1.Open();
                        sorgu = "Update Musteriler set [Bakiye]=Bakiye-" +Convert.ToInt32(radioButton1.Text) + " where M_No='" + giris.o + "'";
                    //SqlConnection bağlan = new SqlConnection(bağlantı);
                    SqlCommand a = new SqlCommand(sorgu, Baglanti1);
                    Baglanti1.Open();
                    a.ExecuteNonQuery();
                    Baglanti1.Close();
                   
                        MessageBox.Show("Hesaptan " + radioButton1.Text.ToString() + " TL Çekildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb1ekle();
                    }
                    else {
                        MessageBox.Show("İşlem iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Baglanti.Close();
            rdr.Close();
        }
        void rb2getir()
        {
            //string hn = giris.o;


            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();
            SqlCommand sorgu1 = new SqlCommand("select Bakiye from Musteriler Where M_No='" + giris.o + "'", Baglanti);
            int girilentutar = Convert.ToInt32(radioButton2.Text);
            SqlDataReader rdr = sorgu1.ExecuteReader();

            while (rdr.Read())
            {

                int hesaptakitutar = Convert.ToInt32(rdr["Bakiye"].ToString());

                if (hesaptakitutar > girilentutar)
                {
                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                    string sorgu;
                        //string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                        SqlConnection Baglanti1 = new SqlConnection();
                        Baglanti1.ConnectionString = baglanti;
                        //Baglanti3.Open();
                        sorgu = "Update Musteriler set [Bakiye]=Bakiye-" + Convert.ToInt32(radioButton2.Text) + " where M_No='" + giris.o + "'";
                        SqlCommand a = new SqlCommand(sorgu, Baglanti1);
                        Baglanti1.Open();
                        a.ExecuteNonQuery();
                        Baglanti1.Close();

                        MessageBox.Show("Hesaptan " + radioButton2.Text.ToString() + " TL Çekildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb2ekle();
                    }
                    else {
                        MessageBox.Show("İşlem iptal edildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                      }
                }
                else
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Baglanti.Close();
            rdr.Close();
        }
        void rb3getir()
        {
            //string hn = giris.o;

            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();
            SqlCommand sorgu1 = new SqlCommand("select Bakiye from Musteriler Where M_No='" + giris.o + "'", Baglanti);
            int girilentutar = Convert.ToInt32(radioButton3.Text);
            SqlDataReader rdr = sorgu1.ExecuteReader();

            while (rdr.Read())
            {

                int hesaptakitutar = Convert.ToInt32(rdr["Bakiye"].ToString());

                if (hesaptakitutar > girilentutar)
                {
                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                    string  sorgu;
                        //bağlantı = "Server=.; Initial Catalog=banka;Integrated Security=SSPI";
                       // string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                        SqlConnection Baglanti1 = new SqlConnection();
                        Baglanti1.ConnectionString = baglanti;
                        //Baglanti1.Open();
                        sorgu = "Update Musteriler set [Bakiye]=Bakiye-" + Convert.ToInt32(radioButton3.Text) + " where M_No='" + giris.o + "'";
                        SqlCommand a = new SqlCommand(sorgu, Baglanti1);
                        Baglanti1.Open();
                        a.ExecuteNonQuery();
                        Baglanti1.Close();

                        MessageBox.Show("Hesaptan " + radioButton3.Text.ToString() + " TL Çekildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb3ekle();
                    }
                    else {
                        MessageBox.Show("İşlem iptal edildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Baglanti.Close();
            rdr.Close();
        }
        void rb4getir()
        {
            //string hn = giris.o;


            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();
            SqlCommand sorgu1 = new SqlCommand("select Bakiye from Musteriler Where M_No='" + giris.o + "'", Baglanti);
            int girilentutar = Convert.ToInt32(radioButton4.Text);
            SqlDataReader rdr = sorgu1.ExecuteReader();

            while (rdr.Read())
            {

                int hesaptakitutar = Convert.ToInt32(rdr["Bakiye"].ToString());

                if (hesaptakitutar > girilentutar)
                {
                    DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                    string  sorgu;
                        //bağlantı = "Server=.; Initial Catalog=banka;Integrated Security=SSPI";
                       // string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
                        SqlConnection Baglanti1 = new SqlConnection();
                        Baglanti1.ConnectionString = baglanti;
                        //Baglanti.Open();
                        sorgu = "Update Musteriler set [Bakiye]=Bakiye-" + Convert.ToInt32(radioButton4.Text) + " where M_No='" + giris.o + "'";
                        SqlCommand a = new SqlCommand(sorgu, Baglanti1);
                        Baglanti1.Open();
                        a.ExecuteNonQuery();
                        Baglanti1.Close();

                        MessageBox.Show("Hesaptan " + radioButton4.Text.ToString() + " TL Çekildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb4ekle();
                    }
                    else {
                        MessageBox.Show("İşlem iptal edildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           Baglanti.Close();
            rdr.Close();
        }
        void rb5getir()
        {
            //string hn = giris.o;


            string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = baglanti;
            Baglanti.Open();
            SqlCommand sorgu1 = new SqlCommand("select * from Musteriler Where M_No='" + giris.o + "'", Baglanti);
            int girilentutar = Convert.ToInt32(radioButton5.Text);
            SqlDataReader rdr = sorgu1.ExecuteReader();

            while (rdr.Read())
            {

                int hesaptakitutar = Convert.ToInt32(rdr["Bakiye"].ToString());

                if (hesaptakitutar > girilentutar)
                {
                     DialogResult onay = new DialogResult();
                    onay = MessageBox.Show("İşlemi Onaylıyor Musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {
                    string sorgu;



                        //bağlantı = "Server=.; Initial Catalog=banka;Integrated Security=SSPI";

                        SqlConnection Baglanti1 = new SqlConnection();
                        Baglanti1.ConnectionString = baglanti;
                        //Baglanti.Open();
                        sorgu = "Update Musteriler set [Bakiye]=Bakiye-" + Convert.ToInt32(radioButton5.Text) + " where M_No='" + giris.o + "'";
                        SqlCommand a = new SqlCommand(sorgu, Baglanti1);
                        Baglanti1.Open();
                        a.ExecuteNonQuery();
                        Baglanti1.Close();

                        MessageBox.Show("Hesaptan " + radioButton5.Text.ToString() + " TL Çekildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rb5ekle();
                    }
                    else {
                        MessageBox.Show("İşlem iptal edildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Baglanti.Close();
            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true){
                rb1getir();
                getr();

            }
            else if (radioButton2.Checked == true) {
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
            else {
                MessageBox.Show("En az bir seçim yapmalısınız.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
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


            


        void rb5ekle(){

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
            a.Parameters.AddWithValue("@islemadi", "Para Çekme");
            a.Parameters.AddWithValue("@tutar", radioButton5.Text.ToString());
            a.Parameters.AddWithValue("@tarih",DateTime.Now);
            
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
            a.Parameters.AddWithValue("@islemadi", "Para Çekme");
            a.Parameters.AddWithValue("@tutar", radioButton4.Text.ToString());
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
            a.Parameters.AddWithValue("@islemadi", "Para Çekme");
            a.Parameters.AddWithValue("@tutar", radioButton3.Text.ToString());
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
            a.Parameters.AddWithValue("@islemadi", "Para Çekme");
            a.Parameters.AddWithValue("@tutar", radioButton2.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


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
            a.Parameters.AddWithValue("@islemadi", "Para Çekme");
            a.Parameters.AddWithValue("@tutar", radioButton1.Text.ToString());
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
            a.Parameters.AddWithValue("@islemadi", "Para Çekme");
            a.Parameters.AddWithValue("@tutar", textBox1.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
        }
       
    }

