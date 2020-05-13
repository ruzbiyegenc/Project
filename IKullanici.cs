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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IKullanici
    {
        string KullaniciAdi {get; set;}
        string Telefon { get; set; }
        string Email { get; set; }
        string Sifre { get; set; }


    }
}
