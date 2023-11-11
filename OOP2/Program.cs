namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();

            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "123456789";
            //musteri1.MusteriNo = "12345";

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;    
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "123456789";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234554579";

            Musteri musteri3 = new GercekMusteri(); //Eğer senin bir base sınıfın varsa o base sınıf referans tutucudur.
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);  

            // Gerçek Müşteri - Tüzel Müşteri iki farklı tip.


        }
    }
}
