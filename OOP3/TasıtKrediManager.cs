using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasıtKrediManager : IKrediManager  //hesaplya sahip
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Tasit Kredisi ödeme planı hesaplandı");
        }
    }
}
