using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //engin demiroğ

            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "12345678910";
            
            TuzelMusteri musteri2= new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //gerçek müsteri - tüzel müsteri   birbirinin yerine kullanılamazlar
            //SOLID 

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();  //musteri classı hem gerçek hem  tüzel musterinin referasını tutabiliyor.
            
            CustomerManager customerManager= new CustomerManager(); //önce olulturdum
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);  
            






        }
    }
}
