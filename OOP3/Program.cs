using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackrediManager = new IhtiyacKrediManager();  //İNTERFACELER DE ONU İMPLEMENTE EDEN CLASSIN REFERASINI TUTABİLİR.
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            //BİRDEN FAZLA LOGGER YAPMAK İSTERSEM
            List<ILoggerService> loggers = new List<ILoggerService>(){ new DatabaseLoggerService(), new FileLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers); 

            //eğer sadece taşıt değil de birden fazla hesap yapmak istersem  list kullanırım 
            List<IKrediManager> krediler= new List<IKrediManager>() { ihtiyackrediManager,tasıtKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           
        }
    }
}
