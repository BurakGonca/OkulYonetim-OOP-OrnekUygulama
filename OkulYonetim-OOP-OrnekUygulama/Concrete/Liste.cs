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
            Ogrenci elif = new Ogrenci("Elif", "Selcuk", 1, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Kadın);
            Ogrenci betul = new Ogrenci("Betül", "Yilmaz", 2, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadın);
            Ogrenci hakan = new Ogrenci("Hakan", "Celik", 3, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Erkek);
            Ogrenci kerem = new Ogrenci("Kerem", "Akay", 4, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Erkek);
            Ogrenci hatice = new Ogrenci("Hatice", "Cinar", 5, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadın);
            Ogrenci selim = new Ogrenci("Selim", "İleri", 6, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Erkek);
            Ogrenci selin = new Ogrenci("Selin", "Kamis", 7, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Kadın);
            Ogrenci sinan = new Ogrenci("Sinan", "Avci", 8, IOgrenci.Sube.A, IOgrenci.Cinsiyet.Erkek);
            Ogrenci deniz = new Ogrenci("Deniz", "Coban", 9, IOgrenci.Sube.C, IOgrenci.Cinsiyet.Erkek);
            Ogrenci selda = new Ogrenci("Selda", "Kavak", 10, IOgrenci.Sube.B, IOgrenci.Cinsiyet.Kadın);

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
    }
}
