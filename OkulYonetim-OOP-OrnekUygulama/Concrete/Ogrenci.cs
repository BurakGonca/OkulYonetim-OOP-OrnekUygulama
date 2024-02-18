using OkulYonetim_OOP_OrnekUygulama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Concrete
{
    internal class Ogrenci : IOgrenci
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
            
        }
        
        public string Ad => _ad;

        public string SoyAd => _soyAd;

        public ushort No => _No;

        public IOgrenci.Sube Subesi => _sube;
        public IOgrenci.Cinsiyet cinsiyeti => _cinsiyet;
        

        public List<Ogrenci> OgrenciListesi { get; set; }

        public DateTime dogumTarihi => _dogumTarihi;
    }
}
