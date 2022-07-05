using System;


//dongüleri biribirine benzeyen işlemleri tekrar etmek için kullanırız.

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Kurs Kampı";
            string kurs2 = "Programlamaya Giris Kampı";
            string kurs3 = "Java";

            //200 ürünü listeleyemezsin böyle olursa ayrı ayrı yazdırırsın. Bunu bir dizi ile tutabailiriz. Dinamik şekilde DÖNGÜYLE yazdırabiliriz

            //array:dizi
            string[] kurslar = new string[] { "Yazılım Gelistirici Kurs Kampı" ,
            "Programlamaya Giris Kampı","Java","Python"};   //böyle yaparak bütün stringleri tuttum.

            for (int i = 0; i < kurslar.Length; i++)  //i sayac kurslar.length diyerek eleman sayısını aldık çünkü uzunluğu bilemezsin
            {
                Console.WriteLine(kurslar[i]);   

            }

            Console.WriteLine("for bitti");

           
            //foreach dizi temelli yapıları tek tek dönmeye yarıyor. kursları dolaş kurs ismi takma ad her elamana kurs ismi veriyoruz alias
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");   
        }
    }
}
