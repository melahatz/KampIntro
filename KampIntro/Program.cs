using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type sayfety : tip güvenliği string tanımlıcaksan veri türünü yazman lazım
            //Do Not Repeat Yourself! :kendini tekrarlama bu yüzden değişkenler kullanıyoruz.
            //kategoriEtiketi aslında bir değer tutucu alias:takma isim
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; 
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;  //GERÇEK HAYATTA BURASI BİR VERŞ KAYNAĞINDAN GELİR
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs Butonu Göster");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Butonu Göster");
            }

            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }




            Console.WriteLine(kategoriEtiketi);
          

        }
    }
}
