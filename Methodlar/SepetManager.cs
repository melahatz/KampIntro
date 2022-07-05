using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//manager gibi ifadeler bir operasyon tutuyor demek.
namespace Methodlar
{
    class SepetManager
    {
        //sepete ürün ekleme işlemi ypıyoruz.
        public void Ekle(Urun urun)  //neyi eklemek istediğini methoda vermen laızm buna parametre deriz . biz ürün eklicez Urun tip urun isimlendirme
        {
            Console.WriteLine("Tebrikler Sepete Eklendi:"+ urun.Adi);

        }

        //yapılmaması gerekn fonksiyon. NEDEN İLLA CLASS  YPIYORUZ BÖYLE DE OLABİLİR FAKAT YÖNETİM DEĞİŞİKLİK YAPARSA HER SAYFADA DEĞİŞİKLİK
        //YAPMAN GEREKİR
        public void Ekle2(string urunAdi,string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: "+ urunAdi + ","+ fiyat +","+stokAdedi);
        }
    }
}
