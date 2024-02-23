using OkulYonetim_OOP_OrnekUygulama.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Abstract
{
    public interface IOgrenci
    {
        string Ad { get; set; }
        string SoyAd { get; set; }
        ushort No { get; set; }
        Sube Subesi { get; set; }
        Cinsiyet cinsiyeti { get; set; }
        DateTime dogumTarihi { get; set; }
        string Mahalle { get; set; }
        string Il { get; set; }
        string Ilce { get; set; }
        Adres OgrenciAdresi { get; set; }
        List<Ders> OgrenciDersleri { get; set; }
        List<Kitap> OgrenciOkuduguKitaplar {  get; set; }

        double NotOrtalamasi();

        enum Sube
        {
            A = 1, B = 2, C = 3, D = 4, E = 5
        }

        enum Cinsiyet
        {
            Kadin = 1,
            Erkek
        }

    }
}
