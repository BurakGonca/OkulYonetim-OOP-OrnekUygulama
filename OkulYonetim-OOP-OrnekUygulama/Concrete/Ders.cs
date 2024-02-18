using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Concrete
{
    public class Ders
    {
        public byte Not { get; set; }
        public string DersinAdi { get; set; }
        public Ders(string dersAdi, byte not)
        { 
            Not= not;
            DersinAdi= dersAdi;
        }
    }
}
