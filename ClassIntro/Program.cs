using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "melo";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;
            //bunu da classları kullanarak yaparsın kendin veri tanımlıyor gibi düşün.
            //değişkenimiz bundan önce sadece string di şuan değişkenimiz kurs . Kursun 3 tane özelliği var 

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 25;

            //Console.WriteLine(kurs1.KursAdi + ' ' + kurs1.Egitmen);

            //Kurs tutuyoruz . Öncekinde string tuttugun için string yazdın.
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar) //kurs burda takma isim
            {
                Console.WriteLine(kurs.KursAdi + ":" +kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen{ get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
