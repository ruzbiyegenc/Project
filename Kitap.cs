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
    class Kitap: IKitap
    {
        private int v1;
        private string text1;
        private int v2;
        private string text2;
        private int v3;

        public int BandrolNo { get; set; }
        public string KitapAdi { get; set; }
        public string Tur { get; set; }
        public int BasimTarihi { get; set; }
        public int Fiyat { get; set; } 

        public Kitap(int bandrol, string kad, string ktur, int tarih, int ucret)
        {
            BandrolNo = bandrol;
            KitapAdi = kad;
            Fiyat = ucret;
            BasimTarihi = tarih;
            Tur = ktur;
        }

        public Kitap(int v1, string text1, int v2, string text2, int v3)
        {
            this.v1 = v1;
            this.text1 = text1;
            this.v2 = v2;
            this.text2 = text2;
            this.v3 = v3;
        }
    }
}
