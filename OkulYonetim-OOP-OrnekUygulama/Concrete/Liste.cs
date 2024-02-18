using OkulYonetim_OOP_OrnekUygulama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Concrete
{
    internal class Liste : IList
    {
        public List<IOgrenci> OgrenciListesi { get; set; }

        List<Ogrenci> TumOgrenciListesi = new List<Ogrenci>();
        public Liste()
        {
            OgrenciGirisleri();
        }

        private void OgrenciGirisleri()
        {
            Ogrenci elif = new Ogrenci("Elif", "Selcuk", 1, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Kadin, new DateTime(2000, 10, 25));
            Ogrenci betul = new Ogrenci("Betül", "Yilmaz", 2, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadin, new DateTime(1999, 10, 25));
            Ogrenci hakan = new Ogrenci("Hakan", "Celik", 3, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Erkek, new DateTime(2003, 10, 25));
            Ogrenci kerem = new Ogrenci("Kerem", "Akay", 4, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Erkek, new DateTime(2005, 10, 25));
            Ogrenci hatice = new Ogrenci("Hatice", "Cinar", 5, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadin, new DateTime(1998, 10, 25));
            Ogrenci selim = new Ogrenci("Selim", "İleri", 6, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Erkek, new DateTime(1997, 10, 25));
            Ogrenci selin = new Ogrenci("Selin", "Kamis", 7, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Kadin, new DateTime(1991, 10, 25));
            Ogrenci sinan = new Ogrenci("Sinan", "Avci", 8, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Erkek, new DateTime(2004, 10, 25));
            Ogrenci deniz = new Ogrenci("Deniz", "Coban", 9, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Erkek, new DateTime(2003, 10, 25));
            Ogrenci selda = new Ogrenci("Selda", "Kavak", 10, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadin, new DateTime(1996, 10, 25));

            elif.OgrenciAdresi = new Adres("Ankara", "Çankaya", "KamilOcak");
            betul.OgrenciAdresi = new Adres("İzmir", "Konak", "Çınartepe");
            hakan.OgrenciAdresi = new Adres("İzmir", "Konak", "Alsancak");
            kerem.OgrenciAdresi = new Adres("Ankara", "Çankaya", "Esatoglu");
            hatice.OgrenciAdresi = new Adres("Gaziantep", "Şahinbey", "Düztepe");
            selim.OgrenciAdresi = new Adres("İstanbul", "Beyoğlu", "Hacıhüsrev");
            selin.OgrenciAdresi = new Adres("İstanbul", "Beşiktaş", "Kuruçeşme");
            sinan.OgrenciAdresi = new Adres("Adana", "Ceyhan", "Azizli");
            deniz.OgrenciAdresi = new Adres("Antalya", "Muratpaşa", "Şirinyalı");
            selda.OgrenciAdresi = new Adres("Muğla", "Marmaris", "Turgut");

            elif.OgrenciDersleri.Add(new Ders("Turkce", 65));
            elif.OgrenciDersleri.Add(new Ders("Matematik", 70));
            elif.OgrenciDersleri.Add(new Ders("Fen", 25));
            elif.OgrenciDersleri.Add(new Ders("Sosyal", 95));

            betul.OgrenciDersleri.Add(new Ders("Turkce", 73));
            betul.OgrenciDersleri.Add(new Ders("Matematik", 68));
            betul.OgrenciDersleri.Add(new Ders("Fen", 92));
            betul.OgrenciDersleri.Add(new Ders("Sosyal", 55));

            hakan.OgrenciDersleri.Add(new Ders("Turkce", 45));
            hakan.OgrenciDersleri.Add(new Ders("Matematik", 70));
            hakan.OgrenciDersleri.Add(new Ders("Fen", 65));
            hakan.OgrenciDersleri.Add(new Ders("Sosyal", 10));

            kerem.OgrenciDersleri.Add(new Ders("Turkce", 78));
            kerem.OgrenciDersleri.Add(new Ders("Matematik", 92));
            kerem.OgrenciDersleri.Add(new Ders("Fen", 85));
            kerem.OgrenciDersleri.Add(new Ders("Sosyal", 95));

            hatice.OgrenciDersleri.Add(new Ders("Turkce", 57));
            hatice.OgrenciDersleri.Add(new Ders("Matematik", 63));
            hatice.OgrenciDersleri.Add(new Ders("Fen", 62));
            hatice.OgrenciDersleri.Add(new Ders("Sosyal", 79));

            selim.OgrenciDersleri.Add(new Ders("Turkce", 42));
            selim.OgrenciDersleri.Add(new Ders("Matematik", 43));
            selim.OgrenciDersleri.Add(new Ders("Fen", 58));
            selim.OgrenciDersleri.Add(new Ders("Sosyal", 76));

            selin.OgrenciDersleri.Add(new Ders("Turkce", 45));
            selin.OgrenciDersleri.Add(new Ders("Matematik", 82));
            selin.OgrenciDersleri.Add(new Ders("Fen", 9));
            selin.OgrenciDersleri.Add(new Ders("Sosyal", 25));

            sinan.OgrenciDersleri.Add(new Ders("Turkce", 63));
            sinan.OgrenciDersleri.Add(new Ders("Matematik", 25));
            sinan.OgrenciDersleri.Add(new Ders("Fen", 80));
            sinan.OgrenciDersleri.Add(new Ders("Sosyal", 99));

            deniz.OgrenciDersleri.Add(new Ders("Turkce", 100));
            deniz.OgrenciDersleri.Add(new Ders("Matematik", 100));
            deniz.OgrenciDersleri.Add(new Ders("Fen", 98));
            deniz.OgrenciDersleri.Add(new Ders("Sosyal", 95));

            selda.OgrenciDersleri.Add(new Ders("Turkce", 88));
            selda.OgrenciDersleri.Add(new Ders("Matematik", 63));
            selda.OgrenciDersleri.Add(new Ders("Fen", 100));
            selda.OgrenciDersleri.Add(new Ders("Sosyal", 55));

            elif.OgrenciOkuduguKitaplar.Add(new Kitap("Kasagi"));
            elif.OgrenciOkuduguKitaplar.Add(new Kitap("Fareler ve Insanlar"));
            elif.OgrenciOkuduguKitaplar.Add(new Kitap("Bremen Mizikacilari"));
            elif.OgrenciOkuduguKitaplar.Add(new Kitap("Secme Masallar"));
            elif.OgrenciOkuduguKitaplar.Add(new Kitap("Mutlu Prens"));

            betul.OgrenciOkuduguKitaplar.Add(new Kitap("Kuyucakli Yusuf"));
            betul.OgrenciOkuduguKitaplar.Add(new Kitap("Kasagi"));
            betul.OgrenciOkuduguKitaplar.Add(new Kitap("Olumsuz Aile"));

            hakan.OgrenciOkuduguKitaplar.Add(new Kitap("Uc Silahsorler"));
            hakan.OgrenciOkuduguKitaplar.Add(new Kitap("Define Adasi"));
            hakan.OgrenciOkuduguKitaplar.Add(new Kitap("Babalar ve Ogullar"));
            hakan.OgrenciOkuduguKitaplar.Add(new Kitap("Olumsuz Aile"));

            kerem.OgrenciOkuduguKitaplar.Add(new Kitap("Insan Neyle Yasar?"));
            kerem.OgrenciOkuduguKitaplar.Add(new Kitap("Degirmenden Mektuplar"));
            kerem.OgrenciOkuduguKitaplar.Add(new Kitap("İki Sehrin Hikayesi"));
            kerem.OgrenciOkuduguKitaplar.Add(new Kitap("Nutuk"));

            hatice.OgrenciOkuduguKitaplar.Add(new Kitap("Nasreddin Hoca Fikralari"));
            hatice.OgrenciOkuduguKitaplar.Add(new Kitap("Hikayeler"));
            hatice.OgrenciOkuduguKitaplar.Add(new Kitap("Oliver Twist"));

            selim.OgrenciOkuduguKitaplar.Add(new Kitap("Beyaz Dis"));
            selim.OgrenciOkuduguKitaplar.Add(new Kitap("Yalniz Efe"));
            selim.OgrenciOkuduguKitaplar.Add(new Kitap("Pinokyo"));
            selim.OgrenciOkuduguKitaplar.Add(new Kitap("Olumsuz Aile"));
            selim.OgrenciOkuduguKitaplar.Add(new Kitap("Mutlu Prens"));

            selin.OgrenciOkuduguKitaplar.Add(new Kitap("Robin Hood"));
            selin.OgrenciOkuduguKitaplar.Add(new Kitap("Robinson Crusoe"));
            selin.OgrenciOkuduguKitaplar.Add(new Kitap("Don Kisot"));

            sinan.OgrenciOkuduguKitaplar.Add(new Kitap("Define Adasi"));
            sinan.OgrenciOkuduguKitaplar.Add(new Kitap("Masallar"));
            sinan.OgrenciOkuduguKitaplar.Add(new Kitap("Vadideki Zambak"));
            sinan.OgrenciOkuduguKitaplar.Add(new Kitap("Secme Masallar"));

            deniz.OgrenciOkuduguKitaplar.Add(new Kitap("Sefiller"));
            deniz.OgrenciOkuduguKitaplar.Add(new Kitap("Olu Canlar"));
            deniz.OgrenciOkuduguKitaplar.Add(new Kitap("Uc Sılahsorler"));

            selda.OgrenciOkuduguKitaplar.Add(new Kitap("Nutuk"));
            selda.OgrenciOkuduguKitaplar.Add(new Kitap("Suc ve Ceza"));
            selda.OgrenciOkuduguKitaplar.Add(new Kitap("Mutlu Prens"));
            selda.OgrenciOkuduguKitaplar.Add(new Kitap("Olumsuz Aile"));

            TumOgrenciListesi.Add(elif);
            TumOgrenciListesi.Add(betul);
            TumOgrenciListesi.Add(hakan);
            TumOgrenciListesi.Add(kerem);
            TumOgrenciListesi.Add(hatice);
            TumOgrenciListesi.Add(selim);
            TumOgrenciListesi.Add(selin);
            TumOgrenciListesi.Add(sinan);
            TumOgrenciListesi.Add(deniz);
            TumOgrenciListesi.Add(selda);

            OgrenciListesi = new List<IOgrenci>(TumOgrenciListesi);

        }

        public List<IOgrenci> SubeyeGoreListele(IOgrenci.Sube sube)
        {
            return OgrenciListesi.Where(o => o.Subesi == sube).ToList();
        }

        public List<IOgrenci> CinsiyeteGoreListele(IOgrenci.Cinsiyet cinsiyet)
        {
            return OgrenciListesi.Where(o => o.cinsiyeti == cinsiyet).ToList();
        }

        public List<IOgrenci> TariheGoreListele(DateTime dogumTarihi)
        {
            return OgrenciListesi.Where(o => o.dogumTarihi > dogumTarihi).ToList();
        }

        public List<IOgrenci> IllereGoreListele()
        {
            return OgrenciListesi.OrderBy(o => o.OgrenciAdresi.Il).ToList();
        }

        


    }
}
