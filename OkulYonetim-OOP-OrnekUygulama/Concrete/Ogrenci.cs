using OkulYonetim_OOP_OrnekUygulama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Concrete
{
    public class Ogrenci : IOgrenci 
    {
        string _ad;
        string _soyAd;
        ushort _No;
        IOgrenci.Sube _sube;
        IOgrenci.Cinsiyet _cinsiyet;
        DateTime _dogumTarihi;
       
        public Ogrenci(string ad, string soyAd, ushort no, IOgrenci.Sube sube, IOgrenci.Cinsiyet cinsiyet, DateTime dogumTarihi )
        {
            _ad = ad;
            _soyAd = soyAd;
            _No = no;
            _sube = sube;
            _cinsiyet = cinsiyet;
            _dogumTarihi = dogumTarihi;
            OgrenciDersleri = new List<Ders>();
            OgrenciOkuduguKitaplar = new List<Kitap>();
        }
        public Ogrenci()
        {
            OgrenciOkuduguKitaplar = new List<Kitap>();
            OgrenciDersleri = new List<Ders>();
        }
        public double NotOrtalamasi()
        {
            return OgrenciDersleri.Average(d => d.Not);
        }

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string SoyAd
        {
            get { return _soyAd; }
            set { _soyAd = value; }
        }

        public ushort No
        {
            get { return _No; }
            set { _No = value; }
        }

        public IOgrenci.Sube Subesi
        {
            get { return _sube; }
            set { _sube = value; }
        }

        public IOgrenci.Cinsiyet cinsiyeti
        {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }
        }

        public DateTime dogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        public string Mahalle { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }

        public Adres OgrenciAdresi { get; set; }

        public List<Ders> OgrenciDersleri { get; set; }
        public List<Kitap> OgrenciOkuduguKitaplar { get; set; }
       
    }
}
