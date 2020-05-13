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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string no = "0";
            no = textBox1.Text;
            switch (no) //bu yapı sayesinde bandrol no ile kitapları getirdik.
            {

                case "0001":
                    {

                        textBox2.Text = "Don Kişot";
                        textBox3.Text = "Adventure";
                        textBox4.Text = "2005";
                        textBox5.Text = "20TL";

                        break;

                    }
                case "0002":
                    {

                        textBox2.Text = "iz";
                        textBox3.Text = "Crime";
                        textBox4.Text = "2011";
                        textBox5.Text = "10TL";
                        break;

                    }
                case "0003":
                    {

                        textBox2.Text = "Nutuk";
                        textBox3.Text = "Söylev";
                        textBox4.Text = "2000";
                        textBox5.Text = "25TL";
                        break;


                    }
                default:
                    {

                        MessageBox.Show("Kitap bulunamadı.");
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)//bu yapı sayesinde bilgileri güncelliyoruz.
        {
            MessageBox.Show("İşlem başarılı.");
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}