using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Abstract
{
    public interface IOgrenci
    {
        string Ad { get; }
        string SoyAd { get; }
        ushort No { get; }
        Sube Subesi { get; }
        Cinsiyet cinsiyeti { get; }
        DateTime dogumTarihi { get; }

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
