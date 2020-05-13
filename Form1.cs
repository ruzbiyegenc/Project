/****************************************************************************
**                             SAKARYA ÜNİVERSİTESİ
**                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                       NESNEYE DAYALI PROGRAMLAMA DERSİ
**                            2019-2020 BAHAR DÖNEMİ
**
**       PROJE NUMARASI.........: Proje1
**       ÖĞRENCİ ADI............: Ruzbiye GENÇ
**       ÖĞRENCİ NUMARASI.......: B181200051
**       DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kullanici admin;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(); // bu kod ile formlar arası geçiş yapıyoruz.
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin = new Kullanici("admin", "12345678900", "admin@bilmemne.com", "123456"); // burda kullanıcı sınıfından nesne oluşturduk.
            if (kullanicitxt.Text== admin.KullaniciAdi && sifretxt.Text==admin.Sifre) // kullanıcı adı ve şifrenin doğruluğunu kontrol ettik.
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

        }

        private void kullanicitxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
