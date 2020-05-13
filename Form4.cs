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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Kullanici kullanici;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kullanici = new Kullanici(kullaniciadtxt.Text, telefontxt.Text, postatxt.Text, ksifretxt.Text);
                MessageBox.Show("Kullanıcı oluşturuldu.");

            }

            catch
            {
                MessageBox.Show ("Kullanıcı oluşturulamadı.Tekrar deneyin.");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kullaniciadtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
