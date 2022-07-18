using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method  //methodlarla tek merkezden kullanabilme imkanı buluyoruz 
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            var result =Add2(4,5);
            Console.WriteLine(result);

        }


        static void Add()  //VOİD GİT BUNU YAP DEMEK GİT İŞLEM YAP BİR YERE BİŞEY YAZ GİBİ veya git bir yere kayıt yap.
        {
            Console.WriteLine("ADDED!!");
        }

        static int Add2(int number1, int number2) //burda istediğim bir sonuc var o yüzden void yerine veri döndürmek istiyorsam veri türünde yaz
        {
            var result=number1 + number2;  //atama yapmak istiyorsam var kullan 
            return result;
        }

    }
}
