using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Concrete
{
    public class Kitap
    {
        public string KitabınAdı { get; set; }
        public Kitap(string kitapAdi)
        {
            KitabınAdı = kitapAdi;
        }
    }
}
