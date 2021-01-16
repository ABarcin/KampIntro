using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();//classın örneği 
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati =80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("-----------Metotlar-------------");
            SepetManager sepetManager = new SepetManager(); 
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,6);
        
        }
    }
}
// metotlar bir blogu tekrar tekrar kullanabilmemiz için yazılır
//do not repeat yourself   kendini tekrar etme (kirliliğe sebep oluyor)
//clean code 
//best practice -- doğru uygulama teknikleri

//bazı konfigurasyonlar hariç yazdıgımız tüm kodlar clasların içinde olur
//conventation yazım kuralı c#
//diziler çoğul isimlendirilir