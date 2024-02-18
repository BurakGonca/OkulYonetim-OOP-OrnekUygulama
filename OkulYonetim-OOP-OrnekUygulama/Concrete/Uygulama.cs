using OkulYonetim_OOP_OrnekUygulama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim_OOP_OrnekUygulama.Concrete
{
    internal class Uygulama
    {
        public static void Calistir()
        {
            Console.WriteLine("------Okul Yönetim Uygulamasi  -----");
            DonguMethod();
        }
        /// <summary>
        /// DonguMethod switch-case yapisi icinde cikis yapilana kadar rekürsif bir secim süreci icinde olacaktir
        /// </summary>
        private static void DonguMethod()
        {
            switch (Menu())
            {
                case "1":
                    ButunOgrenciListele();
                    DonguMethod();
                    break;
                case "2":
                    Console.Write("Listelemek istediginiz subeyi girin (A, B, C, D, E): ");
                    string _sube = Console.ReadLine().ToUpper();
                    if (Enum.TryParse<IOgrenci.Sube>(_sube, out IOgrenci.Sube sube))
                    {
                        SubeyeGoreListele(sube);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nGecersiz şube girisi!");
                        Console.ResetColor();
                    }
                    DonguMethod();
                    break;
                case "3":
                    Console.WriteLine("Listelemek istediginiz cinsiyet tipini girin (E/K)");
                    string _cinsiyet = Console.ReadLine().ToLower();
                    if (_cinsiyet == "e" || _cinsiyet == "k")
                    {
                        IOgrenci.Cinsiyet cinsiyet = _cinsiyet == "e" ? IOgrenci.Cinsiyet.Erkek : IOgrenci.Cinsiyet.Kadin;
                        CinsiyeteGoreListele(cinsiyet);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nGeçersiz cinsiyet girişi!");
                        Console.ResetColor();
                    }
                    DonguMethod();
                    break;
                case "4":
                    Console.WriteLine("\n4 - Dogum Tarihine Göre Ögrencileri Listele ------------------------------------");
                    Console.Write("\nHangi tarihten sonraki öğrencileri listelemek istersiniz: (YIL,AY,GÜN) ");
                    string tarihStr = Console.ReadLine();
                    DateTime tarih;
                    if (DateTime.TryParse(tarihStr, out tarih))
                    {
                        TariheGoreListele(tarih);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nGeçersiz tarih formatı!");
                        Console.ResetColor();
                    }
                    DonguMethod();
                    break;
                case "5":
                    IllereGoreListele();
                    DonguMethod();
                    break;
                case "6":
                    Console.Write("\nÖğrenci numarasını girin: ");
                    ushort ogrenciNo;
                    if (ushort.TryParse(Console.ReadLine(), out ogrenciNo))
                    {
                        OgrenciDersleriListele(ogrenciNo);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçersiz öğrenci numarası!");
                        Console.ResetColor();
                    }
                    DonguMethod();
                    break;
                case "7":
                    Console.Write("\nÖğrenci numarasını girin: ");
                    ushort ogrenciNo7;
                    if (ushort.TryParse(Console.ReadLine(), out ogrenciNo7))
                    {
                        OgrenciKitapListele(ogrenciNo7);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçersiz öğrenci numarası!");
                        Console.ResetColor();
                    }
                    DonguMethod();
                    break;
                case "8":
                    OkuldakiEnYuksekNotlu5Ogrenci();
                    DonguMethod();
                    break;
                case "9":
                    OkuldakiEnDusukNotlu3Ogrenci();
                    DonguMethod();
                    break;
                case "10":
                    SubedekiEnYuksekNotlu5Ogrenci();
                    DonguMethod();
                    break;
                case "11":
                    SubedekiEnDusukNotlu3Ogrenci();
                    DonguMethod();
                    break;
                case "12":
                    Console.Write("\nÖğrenci numarasını girin: ");
                    ushort ogrenciNoo;
                    if (ushort.TryParse(Console.ReadLine(), out ogrenciNoo))
                    {
                        OgrenciNotOrtalamasiGetir(ogrenciNoo);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geçersiz öğrenci numarası!");
                        Console.ResetColor();
                    }
                    DonguMethod();
                    break;
                case "13":
                    SubeninNotOrtalamasiGetir();
                    DonguMethod();
                    break;
                case "14":
                    OgrencininSonOkuduguKitabiGetir();
                    DonguMethod();
                    break;
                case "15":
                    OgrenciEkle();
                    DonguMethod();
                    break;
                case "16":
                    OgrenciGuncelle();
                    DonguMethod();
                    break;
                case "17":
                    OgrenciSil();
                    DonguMethod();
                    break;
                case "18":
                    OgrencininAdresiGir();
                    DonguMethod();
                    break;
                case "19":
                    OgrencininOkuduguKitabiGir();
                    DonguMethod();
                    break;
                case "20":
                    OgrencininNotunuGir();
                    DonguMethod();
                    break;
                case "liste":
                case "lıste":
                    Menu();
                    break;
                case "çıkış":
                case "cikis":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCikis yapiliyor,lütfen bekleyiniz");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nHatalı işlem gerçekleştirildi.Tekrar deneyin.");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.WriteLine("\nMenüyü tekrar listelemek için 'liste', çıkış yapmak için 'çıkış' yazın.");
                    Console.Write("\nYapmak istediginiz islemi seçiniz: ");
                    DonguMethod();
                    break;
            }
        }
      

        private static void Yazdir(List<IOgrenci> ogrenciler)
        {

            Console.WriteLine();
            if (ogrenciler.Count != 0)
            {
                Console.WriteLine("\nSube".PadRight(7) + "No".PadRight(8) + "Adi Soyadi".PadRight(15) + "Not Ort.".PadRight(15) + "Okuduğu Kitap Say.");
                Console.WriteLine("--------------------------------------------------------------");
                foreach (var item in ogrenciler)
                {
                    Console.WriteLine($"{item.Subesi.ToString().PadRight(6)}{item.No.ToString().PadRight(8)}{(item.Ad + " " + item.SoyAd).PadRight(15)}{item.NotOrtalamasi().ToString().PadRight(15)}{item.OgrenciOkuduguKitaplar.Count}");
                }
            }
            else
                Console.WriteLine("Listede goruntulenecek ogrenci yok");

        }

        private static void ButunOgrenciListele()
        {
            Liste liste = new Liste();
            List<IOgrenci> butunOgrenciListe = liste.OgrenciListesi;
            Yazdir(butunOgrenciListe);
        }

        private static void SubeyeGoreListele(IOgrenci.Sube sube)
        {
            Liste liste = new Liste();
            List<IOgrenci> subeyeAitOgrenciler = liste.SubeyeGoreListele(sube);
            Console.WriteLine($"\n{sube} şubesine kayıtlı ogrenciler:");
            Yazdir(subeyeAitOgrenciler);
        }

        private static void CinsiyeteGoreListele(IOgrenci.Cinsiyet cinsiyet)
        {
            Liste liste = new Liste();
            List<IOgrenci> cinsiyeteGoreOgrenciler = liste.CinsiyeteGoreListele(cinsiyet);
            Console.WriteLine($"\n{cinsiyet} cinsiyetli ogrenciler: ");
            Yazdir(cinsiyeteGoreOgrenciler);
        }

        private static void TariheGoreListele(DateTime tarih)
        {
            Liste liste = new Liste();
            List<IOgrenci> tariheGoreOgrenciler = liste.TariheGoreListele(tarih);
            Console.WriteLine($"\n{tarih} tarihinden sonra dogan ogrenciler: ");
            Yazdir(tariheGoreOgrenciler);
        }


        private static void IllereGoreListele()
        {
            Liste liste = new Liste();
            List<IOgrenci> illereGoreOgrenciler = liste.IllereGoreListele();

            Console.WriteLine("\nIllere Göre Ögrencileri Listele --------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sube".PadRight(7) + "No".PadRight(8) + "Adı Soyadı".PadRight(15) + "Il".PadRight(15) + "Ilce".PadRight(15) + "Mahalle");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (var ogrenci in illereGoreOgrenciler)
            {
                Console.WriteLine($"{ogrenci.Subesi.ToString().PadRight(7)}{ogrenci.No.ToString().PadRight(8)}{(ogrenci.Ad + " " + ogrenci.SoyAd).PadRight(15)}{ogrenci.OgrenciAdresi.Il.PadRight(15)}{ogrenci.OgrenciAdresi.Ilce.PadRight(15)}{ogrenci.OgrenciAdresi.Mahalle}");
            }
        }

        private static void OgrenciDersleriListele(ushort ogrenciNo)
        {
            Liste liste = new Liste();
            IOgrenci ogrenci = liste.OgrenciListesi.FirstOrDefault(o => o.No == ogrenciNo);
            if (ogrenci != null)
            {
                Console.WriteLine($"\nÖğrencinin Adı Soyadı: {ogrenci.Ad} {ogrenci.SoyAd}");
                Console.WriteLine($"Öğrencinin Subesi: {ogrenci.Subesi}");
                Console.WriteLine();
                Console.WriteLine("Dersin Adi     Notu");
                Console.WriteLine("--------------------");
                Console.WriteLine();

                foreach (var ders in ogrenci.OgrenciDersleri)
                {
                    Console.WriteLine($"{ders.DersinAdi.PadRight(15)}{ders.Not}");
                }


                double ortalama = ogrenci.OgrenciDersleri.Average(d => d.Not);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Ortalama:      {ogrenci.NotOrtalamasi()}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Öğrenci bulunamadı!");
                Console.ResetColor();
            }
        }


        private static void OgrenciKitapListele(ushort ogrenciNo)
        {
            Liste liste = new Liste();
            IOgrenci ogrenci = liste.OgrenciListesi.FirstOrDefault(o => o.No == ogrenciNo);
            if (ogrenci != null)
            {
                Console.WriteLine($"\nÖğrencinin Adı Soyadı: {ogrenci.Ad} {ogrenci.SoyAd}");
                Console.WriteLine($"Öğrencinin Subesi: {ogrenci.Subesi}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ogrencinin okudugu kitap sayisi: {ogrenci.OgrenciOkuduguKitaplar.Count}");
                Console.ResetColor();
                Console.WriteLine("\nÖğrencinin Okudugu Kitaplar");
                Console.WriteLine("---------------------------");
                foreach (var item in ogrenci.OgrenciOkuduguKitaplar)
                {
                    Console.WriteLine($"{item.KitabınAdı}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Öğrenci bulunamadı!");
                Console.ResetColor();
            }
        }

        private static void OkuldakiEnYuksekNotlu5Ogrenci()
        {
            Liste liste = new Liste();
            var enYuksekNotluOgrenciler = liste.OgrenciListesi
                .OrderByDescending(o => o.OgrenciDersleri.Average(d => d.Not))
                .Take(5)
                .ToList();

            Console.WriteLine("\nOkuldaki en yüksek 5 notlu öğrenciler:");
            Yazdir(enYuksekNotluOgrenciler);
        }

        private static void OkuldakiEnDusukNotlu3Ogrenci()
        {
            Liste liste = new Liste();
            var enDusukNotluOgrenciler = liste.OgrenciListesi
                .OrderBy(o => o.OgrenciDersleri.Average(d => d.Not))
                .Take(3)
                .ToList();

            Console.WriteLine("\nOkuldaki en düşük 3 notlu öğrenciler:");
            Yazdir(enDusukNotluOgrenciler);
        }

        private static void SubedekiEnYuksekNotlu5Ogrenci()
        {
            Console.Write("Şube seçiniz (A, B, C, D, E): ");
            string subeStr = Console.ReadLine().ToUpper();

            if (Enum.TryParse<IOgrenci.Sube>(subeStr, out IOgrenci.Sube sube))
            {
                Liste liste = new Liste();
                var subedekiOgrenciler = liste.SubeyeGoreListele(sube);
                var enYuksekNotluOgrenciler = subedekiOgrenciler
                    .OrderByDescending(o => o.OgrenciDersleri.Average(d => d.Not))
                    .Take(5)
                    .ToList();

                Console.WriteLine($"\n{sube} şubesindeki en yüksek 5 notlu öğrenciler:");
                Yazdir(enYuksekNotluOgrenciler);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz şube girişi!");
                Console.ResetColor();
            }
        }


        private static void SubedekiEnDusukNotlu3Ogrenci()
        {
            Console.Write("Şube seçiniz (A, B, C, D, E): ");
            string subeStr = Console.ReadLine().ToUpper();

            if (Enum.TryParse<IOgrenci.Sube>(subeStr, out IOgrenci.Sube sube))
            {
                Liste liste = new Liste();
                var subedekiOgrenciler = liste.SubeyeGoreListele(sube);
                var enDusukNotluOgrenciler = subedekiOgrenciler
                    .OrderBy(o => o.OgrenciDersleri.Average(d => d.Not))
                    .Take(3)
                    .ToList();

                Console.WriteLine($"\n{sube} şubesindeki en düşük 3 notlu öğrenciler:");
                Yazdir(enDusukNotluOgrenciler);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz şube girişi!");
                Console.ResetColor();
            }
        }


        private static void OgrenciNotOrtalamasiGetir(ushort ogrenciNo)
        {
            Liste liste = new Liste();
            IOgrenci ogrenci = liste.OgrenciListesi.FirstOrDefault(o => o.No == ogrenciNo);
            if (ogrenci != null)
            {
                Console.WriteLine($"Öğrencinin Adı Soyadı: {ogrenci.Ad} {ogrenci.SoyAd}");
                Console.WriteLine($"Öğrencinin Subesi: {ogrenci.Subesi}");
                Console.WriteLine();

                Console.WriteLine($"Ogrencinin not ortalamasi : {ogrenci.NotOrtalamasi() }");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Öğrenci bulunamadı!");
                Console.ResetColor();
            }
        }

        private static void SubeninNotOrtalamasiGetir()
        {
            Console.Write("Şube seçiniz (A, B, C, D, E): ");
            string subeStr = Console.ReadLine().ToUpper();

            if (Enum.TryParse<IOgrenci.Sube>(subeStr, out IOgrenci.Sube sube))
            {
                Liste liste = new Liste();
                var subedekiOgrenciler = liste.SubeyeGoreListele(sube);

                if (subedekiOgrenciler.Count > 0)
                {
                    double notOrtalamasi = subedekiOgrenciler.Average(o => o.OgrenciDersleri.Average(d => d.Not));
                    Console.WriteLine($"\n{sube} şubesinin not ortalaması: {notOrtalamasi:F2}");
                }
                else
                {
                    Console.WriteLine($"Şube {sube} için kayıtlı öğrenci bulunmamaktadır.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz şube girişi!");
                Console.ResetColor();
            }
        }


        private static void OgrencininSonOkuduguKitabiGetir()
        {
            Console.Write("Öğrenci numarasını girin: ");
            ushort ogrenciNo;
            if (ushort.TryParse(Console.ReadLine(), out ogrenciNo))
            {
                Liste liste = new Liste();
                IOgrenci ogrenci = liste.OgrenciListesi.FirstOrDefault(o => o.No == ogrenciNo);

                if (ogrenci != null && ogrenci.OgrenciOkuduguKitaplar.Count > 0)
                {
                    string sonKitap = ogrenci.OgrenciOkuduguKitaplar.Last().KitabınAdı;
                    Console.WriteLine($"\n{ogrenci.Ad} {ogrenci.SoyAd} isimli öğrencinin son okuduğu kitap: {sonKitap}");
                }
                else if (ogrenci != null && ogrenci.OgrenciOkuduguKitaplar.Count == 0)
                {
                    Console.WriteLine($"\n{ogrenci.Ad} {ogrenci.SoyAd} isimli öğrencinin okuduğu kitap bulunmamaktadır.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Öğrenci bulunamadı!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geçersiz öğrenci numarası!");
                Console.ResetColor();
            }
        }


        private static void OgrenciEkle()
        {
            
        }

        private static void OgrenciGuncelle()
        {
            throw new NotImplementedException();
        }

        private static void OgrenciSil()
        {
            throw new NotImplementedException();
        }

        private static void OgrencininAdresiGir()
        {
            throw new NotImplementedException();
        }

        private static void OgrencininOkuduguKitabiGir()
        {
            throw new NotImplementedException();
        }

        private static void OgrencininNotunuGir()
        {
            throw new NotImplementedException();
        }

        private static string Menu()
        {
            Console.WriteLine("\n1 - Bütün öğrencileri listele                         ");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele                   ");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele              ");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele       ");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele       ");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele                  ");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele              ");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele      ");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele       ");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele     ");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele      ");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör                  ");
            Console.WriteLine("13 - Şubenin not ortalamasını gör                     ");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör                ");
            Console.WriteLine("15 - Öğrenci ekle                                     ");
            Console.WriteLine("16 - Öğrenci güncelle                                 ");
            Console.WriteLine("17 - Öğrenci sil                                      ");
            Console.WriteLine("18 - Öğrencinin adresini gir                          ");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir                    ");
            Console.WriteLine("20 - Öğrencinin notunu gir                            ");

            Console.WriteLine("\nMenüyü tekrar listelemek için 'liste', çıkış yapmak için 'çıkış' yazın.");
            Console.WriteLine();
            Console.Write("\nYapmak istediginiz islemi seçiniz: ");
            string islem = Console.ReadLine().ToLower();
            return islem;

        }




    }
}
