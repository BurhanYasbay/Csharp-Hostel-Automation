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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BURHAN;Initial Catalog=Otel;Integrated Security=True");


        private void GelirGider_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label2.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lbl1.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(Icecek) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lbl2.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam4 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lbl3.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblftr.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblftr2.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(İnternet) as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblftr3.Text = oku7["toplam7"].ToString();
            }
            baglanti.Close();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            label6.Text = (personel * 5000).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            int sonuc;
            sonuc = Convert.ToInt32(label2.Text) - (Convert.ToInt32(label6.Text) + Convert.ToInt32(lbl1.Text) + Convert.ToInt32(lbl2.Text) + Convert.ToInt32(lbl3.Text) + Convert.ToInt32(lblftr.Text) + Convert.ToInt32(lblftr2.Text) + Convert.ToInt32(lblftr3.Text));
            label11.Text = sonuc.ToString();
        }


      
    }
}
