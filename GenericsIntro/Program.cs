using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        //list gibi birşeyi ben nasıl yazarım
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>(); //strimg türünde verdik arka planda T string oluyor
            isimler.Add("Melahat");
        }
    }
}
