using Project16_Encapsulation; // Projeye ait Araba sınıfını içe aktarıyoruz

public class Program
{
    public static void Main(string[] args) // Programın giriş noktası
    {
        // İlk araba nesnesi oluşturuluyor; marka, model, renk ve kapı sayısı geçerli
        Araba araba1 = new Araba("Chery", "Tiggo8ProMax", "Beyaz", 4);
        araba1.ArabaBilgisi(); // araba1'in bilgilerini konsola yazdır

        Console.WriteLine();

        // İkinci araba nesnesi oluşturuluyor; kapı sayısı geçersiz (3)
        Araba araba2 = new Araba("Renault", "Austral", "Siyah", 3);
        araba2.ArabaBilgisi(); // araba2'nin bilgilerini yazdır; kapı sayısı geçersiz olduğu için hata mesajı gösterilecek
    }
}
 // Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.

  
