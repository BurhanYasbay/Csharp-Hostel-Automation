using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pansiyon
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris adminGiris = new AdminGiris();
            adminGiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniMüsteri yenimüsteri = new YeniMüsteri();
            yenimüsteri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stoklar stklar = new Stoklar();
            stklar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GelirGider gelirGider = new GelirGider();
            gelirGider.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hostel Registration Application / 2022 Mersin");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
