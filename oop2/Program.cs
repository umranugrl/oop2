using System;
using System.Collections.Generic;
////--------------------1.Polymorfizm = Polymorfizm, farklı nesnelerin aynı isme sahip metotları veya özellikleri farklı şekillerde uygulayabilmesi yeteneğini ifade eder.
//class Program
//{
//    static void Main(string[] args)
//    {
//        IShape sekil1 = new Yamuk(6, 8, 7);
//        IShape sekil2 = new Ucgen(5, 8);

//        Console.WriteLine("Yamuk Alanı: " + sekil1.AlanHesapla());
//        Console.WriteLine("Üçgen Alanı: " + sekil2.AlanHesapla());
//    }
//}
//// Ana sınıf
//interface IShape
//{
//    double AlanHesapla()
//    {
//        return 0;
//    }
//}
//// Yamuk sınıfı
//class Yamuk : IShape
//{
//    public double AltTaban { get; set; }
//    public double UstTaban { get; set; }
//    public double Yukseklik { get; set; }
//    public Yamuk(double altTaban, double ustTaban, double yukseklik)
//    {
//        AltTaban = altTaban;
//        UstTaban = ustTaban;
//        Yukseklik = yukseklik;
//    }
//    public double AlanHesapla()
//    {
//        return (AltTaban + UstTaban) * Yukseklik / 2;
//    }
//}
//// Üçgen sınıfı
//class Ucgen : IShape
//{
//    public double Taban { get; set; }
//    public double Yukseklik { get; set; }
//    public Ucgen(double taban, double yukseklik)
//    {
//        Taban = taban;
//        Yukseklik = yukseklik;
//    }
//    public double AlanHesapla()
//    {
//        return (Taban * Yukseklik) / 2;
//    }
//}
////--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
////--------------------1.Polymorfizm ikinci örrnek
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Polymorphism kullanarak farklı hayvan türlerini aynı tip referansla yönetme
//        Hayvan hayvan1 = new Kopek();
//        Hayvan hayvan2 = new Kedi();

//        // Her hayvanın sesini çıkarması için metodu çağırma
//        hayvan1.SesCikar(); // Köpek sesi
//        hayvan2.SesCikar(); // Kedi sesi
//    }
//}
//// Ana sınıf: Hayvan
//public class Hayvan
//{
//    public virtual void SesCikar()
//    {
//        Console.WriteLine("Hayvan ses çıkarıyor...");
//    }
//}
//// Alt sınıf: Köpek
//public class Kopek : Hayvan
//{
//    public override void SesCikar()
//    {
//        Console.WriteLine("Hav hav!");
//    }
//}
//// Alt sınıf: Kedi
//public class Kedi : Hayvan
//{
//    public override void SesCikar()
//    {
//        Console.WriteLine("Miyav!");
//    }
//}
////--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//// --------------------2.Inheritance = bir sınıfın (veya nesnenin) başka bir sınıftan özellikler ve davranışlar miras almasını sağlar.Kod tekrarını azaltır, kodun yeniden kullanılabilirliğini artırır.
//class Program
//{
//    static void Main(string[] args)
//    {
//        OkulBireyi ogrenci1 = new Ogrenci { Ad = "Ali", Soyad = "Yılmaz", Tc = "12345678901", Sinif = 9 };
//        OkulBireyi ogrenci2 = new Ogrenci { Ad = "Ayşe", Soyad = "Demir", Tc = "23456789012", Sinif = 8 };
//        OkulBireyi ogretmen1 = new Ogretmen { Ad = "Ahmet", Soyad = "Kaya", Tc = "34567890123", Brans = "Matematik", SicilNo = "12345" };
//        OkulBireyi ogretmen2 = new Ogretmen { Ad = "Ayşe", Soyad = "Koç", Tc = "45678901234", Brans = "Tarih", SicilNo = "23456" };

//        Console.WriteLine("Öğrenci 1:");
//        ogrenci1.BilgiVer();
//        Console.WriteLine();

//        Console.WriteLine("Öğrenci 2:");
//        ogrenci2.BilgiVer();
//        Console.WriteLine();

//        Console.WriteLine("Öğretmen 1:");
//        ogretmen1.BilgiVer();
//        Console.WriteLine();

//        Console.WriteLine("Öğretmen 2:");
//        ogretmen2.BilgiVer();
//    }
//}
//// Ana sınıf: OkulBireyi
//class OkulBireyi
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public string Tc { get; set; }

//    // BilgiVer metodu, okul bireyinin bilgilerini gösterir
//    public virtual void BilgiVer()
//    {
//        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Tc: {Tc}");
//    }
//}
//// Öğrenci sınıfı
//class Ogrenci : OkulBireyi
//{
//    public int Sinif { get; set; }
//    // BilgiVer metodu, öğrencinin bilgilerini gösterir
//    public override void BilgiVer()
//    {
//        Console.WriteLine($"Öğrenci - Ad: {Ad}, Soyad: {Soyad}, Tc: {Tc}, Sınıf: {Sinif}");
//    }
//}
//// Öğretmen sınıfı
//class Ogretmen : OkulBireyi
//{
//    public string Brans { get; set; }
//    public string SicilNo { get; set; }
//    // BilgiVer metodu, öğretmenin bilgilerini gösterir
//    public override void BilgiVer()
//    {
//        Console.WriteLine($"Öğretmen - Ad: {Ad}, Soyad: {Soyad}, Tc: {Tc}, Branş: {Brans}, Sicil No: {SicilNo}");
//    }
//}
////---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//// --------------------2.Inheritance ikinci örnek
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Türetilmiş sınıflardan nesneler oluşturuyoruz
//        HavaAraci ucak = new HavaAraci() { Agirlik = 50, Uzunluk = 30, Hiz = 900, KanatGenisligi = 28 };
//        KaraAraci araba = new KaraAraci() { Agirlik = 2, Uzunluk = 4, Hiz = 120, TekerlekSayisi = 4 };
//        DenizAraci gemi = new DenizAraci() { Agirlik = 5000, Uzunluk = 200, Hiz = 40, CanSimitleriSayisi = 100 };

//        // Türetilmiş sınıflara ait metotları çağırıyoruz
//        ucak.Uc();
//        araba.HareketEt();
//        gemi.Yuz();

//        // Ana sınıfa ait metodu çağırıyoruz
//        ucak.BilgileriYazdir();
//        araba.BilgileriYazdir();
//        gemi.BilgileriYazdir();
//    }
//}
//// Ana sınıf (base class)
//public class Arac
//{
//    public double Agirlik { get; set; }
//    public double Uzunluk { get; set; }
//    public double Hiz { get; set; }

//    public void BilgileriYazdir()
//    {
//        Console.WriteLine($"Ağırlık: {Agirlik} ton, Uzunluk: {Uzunluk} metre, Hız: {Hiz} km/saat");
//    }
//}
//// Türetilmiş sınıflar (derived classes)
//public class HavaAraci : Arac
//{
//    public int KanatGenisligi { get; set; }

//    public void Uc()
//    {
//        Console.WriteLine("Havada uçuyor!");
//    }
//}
//public class KaraAraci : Arac
//{
//    public int TekerlekSayisi { get; set; }

//    public void HareketEt()
//    {
//        Console.WriteLine("Karada ilerliyor!");
//    }
//}
//public class DenizAraci : Arac
//{
//    public int CanSimitleriSayisi { get; set; }

//    public void Yuz()
//    {
//        Console.WriteLine("Denizde yüzüyor!");
//    }
//}
////---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//// --------------------2.Inheritance üçüncü örnek
//class Program
//{
//    static void Main(string[] args)
//    {
//        Arsa arsa = new Arsa() { Fiyat = 1000000, Konum = "İstanbul", Alan = 500 };
//        Ev ev = new Ev() { Fiyat = 2500000, Adres = "Ankara", OdaSayisi = 4 };
//        Araba araba = new Araba() { Fiyat = 500000, Marka = "Toyota", Model = "Corolla" };

//        // Her bir varlık için satın alma işlemini gerçekleştir
//        arsa.SatinAl();
//        ev.SatinAl();
//        araba.SatinAl();
//    }
//}
//// Ana sınıf
//public class Maliyet
//{
//    public double Fiyat { get; set; }

//    public virtual void SatinAl()
//    {
//        Console.WriteLine($"Satın alma işlemi gerçekleştiriliyor. Toplam maliyet: {Fiyat} TL");
//    }
//}
//// Türetilmiş sınıflar
//public class Arsa : Maliyet
//{
//    public string Konum { get; set; }
//    public double Alan { get; set; }

//    public override void SatinAl()
//    {
//        base.SatinAl();
//        Console.WriteLine($"Arsa satın alındı. Konum: {Konum}, Alan: {Alan} m²");
//    }
//}
//public class Ev : Maliyet
//{
//    public string Adres { get; set; }
//    public int OdaSayisi { get; set; }
//    public override void SatinAl()
//    {
//        base.SatinAl();
//        Console.WriteLine($"Ev satın alındı. Adres: {Adres}, Oda Sayısı: {OdaSayisi}");
//    }
//}
//public class Araba : Maliyet
//{
//    public string Marka { get; set; }
//    public string Model { get; set; }

//    public override void SatinAl()
//    {
//        base.SatinAl();
//        Console.WriteLine($"Araba satın alındı. Marka: {Marka}, Model: {Model}");
//    }
//}
////---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//// --------------------3.Generic type = belirli bir veri türünden bağımsız olarak çalışabilen ve aynı işlemleri farklı veri tipleri üzerinde uygulayabilen yapılar sağlar.
////ÖR= bir liste oluştururken liste içinde hangi veri türünü tutacağımızı belirleyebiliriz ve aynı liste yapısını farklı veri tipleriyle kullanabiliriz. 
////Bu şekilde yeniden kullanılabilir, esnek ve tip güvenli olmasını sağlarız.
// Generic tip ile ElektronikCihaz sınıfı
//public class ElektronikCihaz<T>
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // ElektronikCihaz sınıfını generic bir şekilde kullanma
//            ElektronikCihaz<int> tv = new ElektronikCihaz<int>("Televizyon", 220);
//            ElektronikCihaz<double> telefon = new ElektronikCihaz<double>("Telefon", 5.0);
//            ElektronikCihaz<int> camasirMakinasi = new ElektronikCihaz<int>("Çamaşır Makinesi", 220);

//            // Bilgileri yazdırma
//            tv.BilgileriYazdir();
//            telefon.BilgileriYazdir();
//            camasirMakinasi.BilgileriYazdir();
//        }
//    }
//    public string Ad { get; set; }
//    public T Voltaj { get; set; }
//    // Kurucu method
//    public ElektronikCihaz(string ad, T voltaj)
//    {
//        Ad = ad;
//        Voltaj = voltaj;
//    }
//    // Bilgileri yazdıran method
//    public void BilgileriYazdir()
//    {
//        Console.WriteLine($"Elektronik Cihaz: {Ad}, Voltaj: {Voltaj}");
//    }
//}
////---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//// --------------------4.Abstract class ile interface arasındaki farklar
//--Abstract sınıflar, hem somut(concrete) hem de soyut (abstract) üyeler içerebilir. Somut üyeler, uygulamalarını içerebilirken, soyut üyeler sadece imzalarıyla tanımlanır.
//--Interface'ler ise yalnızca soyut üyeler içerebilir. Bu üyelerin gövdeleri (implementations) bulunmaz, yalnızca imzaları (signatures) tanımlanır.

//--Bir sınıf yalnızca bir abstract sınıftan türetilirken, birden fazla interface'i uygulayabilir. C# dilinde çoklu kalıtımı destekleyen tek yapı interface'lerdir.

//--Abstract sınıflar genellikle birlikte gruplanabilecek ve ortak özelliklere sahip nesnelerin kalıtımını almak için kullanılır.
//--Interface'ler ise bir nesnenin belirli bir davranışı sağladığını tanımlamak için kullanılır. Farklı sınıflar, aynı interface'i uygulayarak aynı davranışları gerçekleştirebilir.

//--Interface'ler, daha fazla esneklik sağlar. Birden fazla interface'i uygulayarak farklı davranışları bir araya getirebilir ve daha modüler bir kod oluşturabiliriz.
//--Abstract sınıflar ise daha sıkı bağlıdır ve yalnızca bir tane kullanılabilir.

//--C# 8.0'den itibaren, interface'ler de varsayılan implementasyonlar içerebilir. Bu sayede, var olan kodu bozmadan yeni fonksiyonellik eklemek mümkün olur.
//--Abstract sınıflarda varsayılan implementasyonlar kullanılamaz.
////---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//// --------------------5.Encapsulation = verilerin ve bu verilere ait işlemlerin bir arada tutulması sağlar
//class Program
//{
//    static void Main(string[] args)
//    {
//        Sehir sınıfından bir nesne oluşturma
//       Sehir sehir1 = new Sehir();

//        Şehir özelliklerine değer atama
//        sehir1.Ad = "İstanbul";
//        sehir1.Nufus = 15000000;

//        Şehir bilgilerini yazdırma
//        sehir1.SehirBilgileriYazdir();
//    }
//}
//public class Sehir
//{
//    private string ad;
//    private int nufus;
//    Şehir adı özelliğine erişim için property tanımlama
//    public string Ad
//    {
//        get { return ad; }
//        set { ad = value; }
//    }
//    Şehir nüfusu özelliğine erişim için property tanımlama
//    public int Nufus
//    {
//        get { return nufus; }
//        set { nufus = value; }
//    }
//    Şehir bilgilerini yazdıran metod
//    public void SehirBilgileriYazdir()
//    {
//        Console.WriteLine("Şehir adı: " + ad);
//        Console.WriteLine("Şehir nüfusu: " + nufus);
//    }
//}