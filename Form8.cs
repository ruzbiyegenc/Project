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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no="0";
            no = textBox1.Text;
            switch(no) //bu yapı sayesinde bandrol no ile kitapları getirdik.
            {

                case "0001":
                    {

                        label2.Text = "Don Kişot";
                        label3.Text = "Adventure";
                        MessageBox.Show("Emanet alımı başarılı.");
                        break;

                    }
                case "0002":
                    {

                        label2.Text = "İz";
                        label3.Text = "Crime";
                        MessageBox.Show("Emanet alımı başarılı.");
                        break;

                    }
                case "0003":
                    {

                        label2.Text = "Nutuk";
                        label3.Text = "Söylev";
                        MessageBox.Show("Emanet alımı başarılı.");
                        break;
                    

                    }
                default:
                    {

                        MessageBox.Show("Kitap bulunamadı.");
                        break;
                    }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
