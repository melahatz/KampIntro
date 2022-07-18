using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interfaceler genellikle operasyonel classlarda kullanılır.
    interface IKrediManager  //imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda class olarak değilde interface olarak oluştururz.interface şablon görevi görür.
    //eğerki birisi bu interface i kullanırsa o arkadaşım aşağudaki metodu içermek zorunda.
    {
        void Hesapla();
        void BiseyYap();
       
    }

    //interface'i birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    
}
