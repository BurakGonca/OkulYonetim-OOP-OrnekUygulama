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
            Ogrenci elif = new Ogrenci("Elif", "Selcuk", 1, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Kadin , new DateTime(2000,10,25));
            Ogrenci betul = new Ogrenci("Betül", "Yilmaz", 2, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadin, new DateTime(1999, 10, 25));
            Ogrenci hakan = new Ogrenci("Hakan", "Celik", 3, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Erkek, new DateTime(2003, 10, 25));
            Ogrenci kerem = new Ogrenci("Kerem", "Akay", 4, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Erkek, new DateTime(2005, 10, 25));
            Ogrenci hatice = new Ogrenci("Hatice", "Cinar", 5, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadin, new DateTime(1998, 10, 25));
            Ogrenci selim = new Ogrenci("Selim", "İleri", 6, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Erkek, new DateTime(1997, 10, 25));
            Ogrenci selin = new Ogrenci("Selin", "Kamis", 7, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Kadin, new DateTime(1991, 10, 25));
            Ogrenci sinan = new Ogrenci("Sinan", "Avci", 8, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Erkek, new DateTime(2004, 10, 25));
            Ogrenci deniz = new Ogrenci("Deniz", "Coban", 9, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Erkek, new DateTime(2003, 10, 25));
            Ogrenci selda = new Ogrenci("Selda", "Kavak", 10, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadin, new DateTime(1996, 10, 25));

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
            return OgrenciListesi.Where(o=> o.cinsiyeti == cinsiyet).ToList();
        }

        public List<IOgrenci> TariheGoreListele (DateTime dogumTarihi)
        {
            return OgrenciListesi.Where(o=> o.dogumTarihi > dogumTarihi).ToList();
        }
    }
}
