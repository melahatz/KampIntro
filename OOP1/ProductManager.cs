using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //productmanager görürsen içinde ürünler ile ilgili operasyonlar(metholar) olduğunu anla.
    class ProductManager
    {
        public void Add(Product product) //bir ürün ekliceksek bu methoda neyi ekleyeceğimizi söylememiz gerekir(parametre yapıları)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

      

    }
}
