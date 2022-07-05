using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    
    class Urun  //bir ürünün ürün olabilmesi için çeşitli özellikleri barındırması lazım. içinde birden fazla veri tutabilirsin
    {
        //property:özellik
        public int Id { get; set; }   //prop tab tab yap bunu kullanırken kolaylık. bir datayı diğer datalardan ayıran eşsiz değer
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }

    }
}
