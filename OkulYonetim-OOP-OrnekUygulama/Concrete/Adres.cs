using OkulYonetim_OOP_OrnekUygulama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Concrete
{
    public class Adres
    {
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }

        public Adres(string il, string ilce, string mahalle)
        {
            Il = il;
            Ilce = ilce;
            Mahalle = mahalle;
        }
    }

}
