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
    public partial class paratransferi : Form
    {
        public paratransferi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hesapbilgileri frm = new hesapbilgileri();
            frm.Show();
            this.Hide();
        }
        //SqlConnection baglanti1 = new SqlConnection("Server=.; database=banka; integrated security=SSPI;MultipleActiveResultSets=True");
        string baglanti = "Server=BILGPROG-24\\SQLEXPRESS;Database=banka;User Id=sa;Password=1;MultipleActiveResultSets=True";
        SqlConnection Baglanti = new SqlConnection();
        
      public string MNO, Tc;
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.ConnectionString = baglanti;
            //Baglanti.Open();
            try
            {
                if (Baglanti.State != ConnectionState.Open)
                    Baglanti.Open();


                    SqlCommand sorgu1 = new SqlCommand("select * from Musteriler Where M_No='" + textBox2.Text + "'", Baglanti);
                    SqlDataReader oku = sorgu1.ExecuteReader();
                    oku.Read();
                    DialogResult onay=new DialogResult();
                    onay= MessageBox.Show(oku["Adsoyad"].ToString() + " Adlı Kişiye Hesabınızdan " + textBox1.Text.ToString() + " TL Göndermek İstiyormusunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onay == DialogResult.Yes)
                    {

                        SqlCommand komut1 = new SqlCommand("Update Musteriler set [Bakiye]=Bakiye-" + textBox1.Text + " where M_No='" + giris.o + "'", Baglanti);
                        komut1.ExecuteNonQuery();

                        SqlCommand komut3 = new SqlCommand("Update Musteriler set [Bakiye]=Bakiye+" + textBox1.Text + " where M_No='" + textBox2.Text + "'", Baglanti);
                        komut3.ExecuteNonQuery();

                        MessageBox.Show(oku["Adsoyad"].ToString() + " Adlı Kişiye Hesabınızdan " + textBox1.Text.ToString() + " TL Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ekletransfer();
                    gonderilentransfer();
                    }
                    else
                    {
                        MessageBox.Show("İşlem İptal Edildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (Baglanti.State != ConnectionState.Closed)
                    Baglanti.Close();
            }
        }

        private void paratransferi_Load(object sender, EventArgs e)
        {

        }

        void ekletransfer()
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
            a.Parameters.AddWithValue("@islemadi", "Para Transferi");
            a.Parameters.AddWithValue("@tutar", textBox1.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
        void gonderilentransfer()
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
            a.Parameters.AddWithValue("@mno", textBox2.Text.ToString());
            a.Parameters.AddWithValue("@islemadi", "Başka Hesaptan Para Transferi Yapıldı.");
            a.Parameters.AddWithValue("@tutar", textBox1.Text.ToString());
            a.Parameters.AddWithValue("@tarih", DateTime.Now);

            a.ExecuteNonQuery();
            bag.Close();


        }
    }
    }
