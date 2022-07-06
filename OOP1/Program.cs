using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1=new Product(); //ürün oluşturmak için classı böyle tanımlarım.  //Classİsmi nesneisim=new Classismi
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //bu şekilde de olabilirdi
            Product product2=new Product {Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };

            //PascalCase(sınıf)   //camelCase(isimlendirme)
            ProductManager productManager=new ProductManager();   //bunu kullanarak product1 veya 2 yi alıp kullanıcıya göndermen gerek
            productManager.Add(product1);  //İÇİNE NE EKLEYİM YANİ PARAMETRE LAZIM.
            Console.WriteLine(product1.ProductName);

            //int,double,floatvs----- deger tip
            //diziler,class,abstract class,interface ---referans tip


        }
    }
}
