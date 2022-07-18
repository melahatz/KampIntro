using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //METHOD INJECTİON
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)  //ister konu ister tasıt ister ihitac kredisi gönderebilrim buraya,AYNI ZAMANDA LOGLAMAK İSTİYORUM
        {
            //basvuran bilgilerini değerlendirime
            //.............
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla   --bu kod çalışır fakar sadece konut kredisini hesaplar
            //hangi krediyi gönderirsen onun hesaplası çalıştırıyor.

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //birden fazla kredinin hesabını yapmak istiyorsam list kullanırım
        {
            foreach (var kredi in krediler)   //listedeki her bir kredinin hesabını yap
            {
                kredi.Hesapla();
            }
        }

    }
}
