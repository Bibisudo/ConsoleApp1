namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine();

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayı1'i sayı2'ye atıyorum. Yani sayı1'in değerini, sayı2'nin değerine eşitler, sayı2 ile olan bağlantı kopar.
            sayi2 = 65;
            // sayı1 ??? -> 30 olur.

            int[] sayilar1 = new int[] { 10, 20,  30 };
            int[] sayilar2 = new int[] {100,  200, 300  };
            sayilar1 = sayilar2; //sayılar 1'in referans numarası, sayılar 2'nin referans numarasına eşitleniyor.
            sayilar2[0] = 999;   //yani sayılar 1 referansı stackteki artık heapte sayılar2 referansının adresini işaret etmeye başlıyor.
            // sayılar1[0] =? -> 999 olur. Çünkü değişken tipleri farklı!

            // imt, decimal, flood, double, bool değer tip.
            //array, class, interface referans değişken tipi.
        }
    }
}