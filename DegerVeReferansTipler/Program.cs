using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //sayisal veri tipler; int ,float, decimal, bool, gibi bunlar değer tip stack de gerçekleşir.sadece degeri aktarırsın.deger kopyalıyor
            int sayi1 = 10;
            int sayi2 = 30; 
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1? : 30

            //array class interface bunlar referans tip stack ve heap de gerçekleşir.Adres kopyalaması yapar
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;  //sayılar1 in referans no su sayılar2 nin referans numarasına eşittir
            sayilar2[0] = 999;
            //sayilar1[0]? :999
        }
    }
}
