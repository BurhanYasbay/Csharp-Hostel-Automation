using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pansiyon
{
    public partial class YeniMüsteri : Form
    {
        
        public YeniMüsteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BURHAN;Initial Catalog=Otel;Integrated Security=True");


        private void YeniMüsteri_Load(object sender, EventArgs e)
        {
            //101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from ODA101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {

                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }
            //102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from ODA102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }
            //103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from ODA103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
            //104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from ODA104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
            //105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from ODA105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }
            //106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from ODA106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }
            //107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from ODA107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }
            //108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from ODA108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }
            //109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from ODA109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
        }

        private void ButtonsOdaClick(object sender, EventArgs e)
        {
            Button BtnOda = (Button)sender; 
            TxtOdaNo.Text = BtnOda.Text;
            baglanti.Open();
            //SqlCommand komut = new SqlCommand("Insert into Oda101 Oda102 Oda103 Oda104 Oda105 Oda106 Oda107 Oda108 Oda109 (Adi,Soyadi) values ('" + BtnOda.Text + "')", baglanti);
            SqlCommand komut = new SqlCommand("insert into Oda" + BtnOda.Text + " (Adi, Soyadi) values (@ad,@soyad)", baglanti);
            komut.Parameters.AddWithValue("@ad" , TxtAdi.Text);
            komut.Parameters.AddWithValue("@soyad", TxtSoyadi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close(); 
               
            
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)    
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc=BuyukTarih - KucukTarih;
            label9.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label9.Text) * 1000;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,OdaNo,Telefon,TC,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + TxtOdaNo.Text + "','" +MskTxtTelefon.Text + "','" + MskTxtTC.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Tamamlandı");
        }

    }
}
