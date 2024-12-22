/* using System;

class Program
{
    // GERİYE DEĞER DÖNDÜRMEYEN BİR VOİD METOT
    public static void SarkiSozuYazdir()
    {
        Console.WriteLine("Sen beni boşuna hiç, kalbinle sevmedin...");
        Console.WriteLine("Aklın hep doluydu, sen beni hiç dinlemedin...");
    }

    static void Main(string[] args)
    {
        // Metodu çağırıyoruz
        SarkiSozuYazdir();
    }
}
*/

/*
 

 using System;
class Program
{
    //GERİYE TAM SAYI DÖNDÜREN BİR METOT
    public static int rastgeleSayi()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(1, 51);
        Console.WriteLine("Üretilen sayı: " + sayi);
        return sayi % 2;
    }
    static void Main(string[] args)
    {
        int kalan = rastgeleSayi();
        Console.WriteLine("2'ye bölümünden kalan: " + kalan);
    }

}
*/

/*
 
using System;

class Program
{
    // Parametre olarak iki sayıyı alıp çarpımını döndüren metot
    public int Carpma(int a, int b)
    {
        return a * b;  // a ve b'nin çarpımını döndürür
    }

    static void Main(string[] args)
    {
        // Program sınıfından bir nesne oluşturuluyor
        Program program = new Program();

        // Carpma metodunu çağırıyoruz ve sonucu alıyoruz
        int sonuc = program.Carpma(5, 4);  // a = 5 ve b = 4

        // Sonucu ekrana yazdırıyoruz
        Console.WriteLine("Çarpım Sonucu: " + sonuc);  // Çıktı: Çarpım Sonucu: 20
    }
}
*/

using System;

class Program
{
    // Parametre olarak isim ve soyisim alıp, ekrana hoş geldiniz mesajı yazdıran metot
    public void HosGeldiniz(string isim, string soyisim)
    {
        // Parametre olarak alınan isim ve soyismi ekrana yazdırır
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }

    static void Main(string[] args)
    {
        // Program sınıfından bir nesne oluşturuluyor
        Program program = new Program();

        // HosGeldiniz metodunu çağırıyoruz ve parametre olarak isim ve soyisim veriyoruz
        program.HosGeldiniz("Ahmet", "Yılmaz");  // "Hoş Geldiniz Ahmet Yılmaz" mesajı ekrana yazdırılır
    }
}

