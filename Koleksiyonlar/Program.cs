using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////yeni eleman eklemek istersek hata vericektir.Arrayler sizin oluşturduğunuz sınırda takılır

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]); //böyle ekleriz fakat yeni bellek ayırdığımızdan diğerlerini de okumak istersek okuyamayız.
            //Console.WriteLine(isimler[0]); //boş gelir

            //Arraylerde sabitlik var yani 4 elemanı 5 yaparsınız ama diğer elemanları kaybedersiniz.Çünkü NEW demek yeni adres demek.
            //


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            //isimler2.Add("Engin"); böyle de eleman ekleyebilrim listeye
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");  //add koleksiyonunu çağırdım
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //koleksiyonlarda arrayler gibi değerleri kaybetmemizi engellicek altyapı var.


        }
    }
}
