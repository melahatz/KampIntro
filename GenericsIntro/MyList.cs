using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> //BEN MYLİST İMDE T ile çalışıcam. Bir tip gelicek aşağıyı ona göre tanımlıcam
    {
        T[] Items;  //CLASIN BÜTÜN METHODLARININ ERİŞECEĞİM ARRAY TANIMLADIM.Eklemek için new zorunlulupum var.Başladıpımda 0 ile başlamak için const. var
        public MyList()  //constructor:clası bir yerde new lersen mylist başlangıcta(otomatik) çalışıyor
        {
            Items = new T[0];
        }
        
        //item:eleman
        public void Add(T item)  //T olarak ne verirsem istediğim elemanın türü de odur demek
        {
            //dizim şuan 0 elemanlı önce dizime elaman eklemem için dizimin sayısını bir artırmalıyım. Items.length+1 elman sayısını 1 artırır

            T[] tempArray = Items;  //gecici dizi oluşturdum elemanlarım kaybolmasın diye. Çünkü new yeni referans no su alır Uçmasın diye.
            Items=new T[Items.Length+1];
            for (int i = 0; i < tempArray.Length; i++) //emanet verimizi geri alıcaz tempArraydekileri items a atıcam
            {
                Items[i] = tempArray[i]; //verdiğim elemanlarım kendi üzerime geri alıyorum items eski değerlerine kavuştu
                
            }

            Items[Items.Length-1] = item;  //Items.length-1 çünkü 6 elemanlıysa indeksi 5 olucak şuan ekledim eklemek istediğim elemanı
        }
    }
}
