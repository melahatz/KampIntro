using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();  //class tanımlamak için.class dan değişken tanımlamak gibi düşün. bir ürün olulturdun burda
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();  //class tanımlamak için.class dan değişken tanımlamak gibi düşün. bir ürün olulturdun burda
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            //urun arrayı oluşturalım
            Urun[] Urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in Urunler) //urunler dizisini tek tek gez
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati); 
                Console.WriteLine(urun.Aciklama);
            }

            Console.WriteLine("*********************Methodlar*******************");
            //instance:class örneği oluşturmak
            //encapsulation:ayrı ayrı yazacağın yapıyı bir düzrnin içine sokuyorsun ekle2 yi ekle fonk. ile düzene sokmuş oldun


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //parametreli methodun. parametre vermelisin
            sepetManager.Ekle(urun2);
            //sepetManager.Ekle();
            //sepetManager.Ekle(); 4 farklı sayfada aynı sonucu verdi yarın farklı bir değişiklik gelirse methodu değiştir gerisi değişir.


            sepetManager.Ekle2("Armut", "Yesil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yesil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);
            //3 FARKLI SAYFADA BUNLARI YAPABİLİR . fakat düzeltme olduğunda 3 farklı sayfayı düzeltmem gerekir.

        }
    }
}
