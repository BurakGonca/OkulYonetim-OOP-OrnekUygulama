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
                    OgrenciTumNotlariListele();
                    DonguMethod();
                    break;
                case "7":
                    OgrenciKitapListele();
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
                    OgrenciNotOrtalamasiGetir();
                    DonguMethod();
                    break;
                case "13":
                    SubeninNotOrtalamasiGeti();
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
                    Console.WriteLine($"{item.Subesi.ToString().PadRight(6)}{item.No.ToString().PadRight(8)}{(item.Ad + " " + item.SoyAd).PadRight(15)}{item.No.ToString().PadRight(15)}{item.cinsiyeti}");
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
            throw new NotImplementedException();
        }

        private static void OgrenciTumNotlariListele()
        {
            throw new NotImplementedException();
        }

        private static void OgrenciKitapListele()
        {
            throw new NotImplementedException();
        }

        private static void OkuldakiEnYuksekNotlu5Ogrenci()
        {
            throw new NotImplementedException();
        }

        private static void OkuldakiEnDusukNotlu3Ogrenci()
        {
            throw new NotImplementedException();
        }

        private static void SubedekiEnYuksekNotlu5Ogrenci()
        {
            throw new NotImplementedException();
        }

        private static void SubedekiEnDusukNotlu3Ogrenci()
        {
            throw new NotImplementedException();
        }

        private static void OgrenciNotOrtalamasiGetir()
        {
            throw new NotImplementedException();
        }

        private static void SubeninNotOrtalamasiGeti()
        {
            throw new NotImplementedException();
        }

        private static void OgrencininSonOkuduguKitabiGetir()
        {
            throw new NotImplementedException();
        }

        private static void OgrenciEkle()
        {
            throw new NotImplementedException();
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
