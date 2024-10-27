# Proje Hakkında

C# dilinde kapsülleme (encapsulation) kavramını kullanarak bir `Araba` sınıfı oluşturmayı amaçlayan bir projedir. Bu proje, araç nesneleri üzerinde temel işlemler yapmayı sağlar ve kullanıcıların araba bilgilerini yönetmelerine yardımcı olur.

## İçindekiler

- [Proje Hakkında](#proje-hakkında)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Örnek Kod](#örnek-kod)

## Proje Hakkında

Bu proje, bir `Araba` sınıfı içerir. `Araba` sınıfı, aşağıdaki özelliklere sahiptir:

- **Marka**: Arabanın markası
- **Model**: Arabanın modeli
- **Renk**: Arabanın rengi
- **Kapı Sayısı**: Arabanın kapı sayısı (geçerli aralık: 4 veya daha fazla)

Kapsülleme sayesinde, kapı sayısının geçerliliği kontrol edilir ve geçersiz bir değer verilmesi durumunda hata mesajı gösterilir.

## Kurulum

1. Projeyi klonlayın veya indirin.
   ```bash
   git clone https://github.com/kullaniciadi/Proje16_Encapsulation.git
   ```
2. Visual Studio veya benzeri bir IDE ile projeyi açın.
3. Projeyi çalıştırmak için ilgili .NET ortamının kurulu olduğundan emin olun.

## Kullanım

Projenin giriş noktası `Program` sınıfıdır. Aşağıdaki adımları izleyerek projeyi çalıştırabilirsiniz:

1. `Araba` sınıfından bir nesne oluşturun ve geçerli özellikleri verin.
2. `ArabaBilgisi` metodunu çağırarak araba bilgilerini konsola yazdırın.
3. Geçersiz bir kapı sayısı ile yeni bir `Araba` nesnesi oluşturun; hata mesajının çıktığını gözlemleyin.

## Örnek Kod

```csharp
using Project16_Encapsulation;

public class Program
{
    public static void Main(string[] args)
    {
        // İlk araba nesnesi
        Araba araba1 = new Araba("Chery", "Tiggo8ProMax", "Beyaz", 4);
        araba1.ArabaBilgisi();
        
        Console.WriteLine();
        
        // İkinci araba nesnesi (geçersiz kapı sayısı)
        Araba araba2 = new Araba("Renault", "Austral", "Siyah", 3);
        araba2.ArabaBilgisi();
    }
}
