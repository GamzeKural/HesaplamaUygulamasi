using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesaplamaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Sayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Topla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            int sonuc = sayi1 + sayi2;
            txt_Sonuc.Text = sonuc.ToString();
            
        }

        private void btn_Cikar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            int sonuc = sayi1 - sayi2;
            txt_Sonuc.Text = sonuc.ToString();
        }

        private void btn_Carp_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            int sonuc = sayi1 * sayi2;
            txt_Sonuc.Text = sonuc.ToString();
        }

        private void btn_Bol_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_Sayi1.Text);
            int sayi2 = Convert.ToInt32(txt_Sayi2.Text);
            int sonuc = sayi1 / sayi2;
            txt_Sonuc.Text = sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hesaplama uygulamasına hoşgeldiniz.");
        }
    }
}
