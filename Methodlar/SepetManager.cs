using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        //naming convention isimlendirme kuralı
        //syntax 
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Sepete Eklendi: "+urun.Adi);
        
        }
        public void Ekle2(string urunAdi,string Aciklama,double fiyat,int stokAdeti) //böyle kullanırsan bu fonksiyona yeni bir parametre koymak istediğin zaman tüm sayfaları değiştirmek zorunda kalırsın sebebi ise kullanım şekli değişiyor parametre 3 den 4 e cıkıyor
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);
        }
    }
}
