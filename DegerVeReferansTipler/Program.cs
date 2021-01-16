using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi2 nin değerini sayi 1 e atadın ve sayi 2 ile olan irtibat koparıldı
            sayi2 = 65;
            Console.WriteLine(sayi1);//int decimal float double bool değer veriler 
            int[] sayilar1 = new int[] { 10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //array class interface referans türleridir yani en son değer ne ise onu gösterir.
            Console.WriteLine(sayilar1[0]);

            //Bellekte 
            //Stack               ve              Heap vardır
            //sayi1=10 sayi1 in değeri =10        
            //sayi2=30

            //Stack                ve                         Heap
            //sayilar1            new dendiği anda         [10,20,30]    adresi mesela 101
            //sailar2             new dendiği anda         [100,200,300]    adresi mesela 102
            //16 ıncı satırın okuması sayılar 1 in referans numarası = sayilar 2 nin referans numarası


        }
    }
}
