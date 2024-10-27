using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project16_Encapsulation
{
    // Araba sınıfı, araçların marka, model, renk ve kapı sayısını temsil eder.
    internal class Araba
    {
        // Sınıfın alanları
        public string marka;       // Arabanın markası
        public string model;      // Arabanın modeli
        public string renk;       // Arabanın rengi
        public int kapısayısı;    // Arabanın kapı sayısı

        // Yapıcı metod, Araba sınıfının bir örneği oluştururken başlangıç değerlerini ayarlar.
        public Araba(string marka, string model, string renk, int kapısayısı)
        {
            this.marka = marka;        // Markayı ayarla
            this.model = model;        // Modeli ayarla
            this.renk = renk;          // Rengi ayarla
            Kapısayısı = kapısayısı;   // Kapı sayısını ayarla 
        }

        // Marka özelliği
        public string Marka
        {
            get { return marka; }      // Marka değerini döndür
            set { marka = value; }     // Marka değerini ayarla
        }

        // Model özelliği
        public string Model
        {
            get { return model; }      // Model değerini döndür
            set { model = value; }     // Model değerini ayarla
        }

        // Renk özelliği
        public string Renk
        {
            get { return renk; }       // Renk değerini döndür
            set { renk = value; }      // Renk değerini ayarla
        }

        // Kapı sayısı özelliği
        public int Kapısayısı
        {
            get { return kapısayısı; } // Kapı sayısını döndür
            set
            {
                // Kapı sayısı 2 veya 4 olmalı
                if (value == 2 || value == 4)
                {
                    kapısayısı = value; // Geçerli değer ayarla
                }
                else
                {
                    Console.WriteLine("Geçersiz kapı sayısı girdiniz."); // Hata mesajı
                    kapısayısı = -1; // Geçersiz durum için kapı sayısını -1 yap
                }
            }
        }

        // Araba bilgilerini konsola yazdıran metod
        public void ArabaBilgisi()
        {
            // Arabanın bilgilerini formatlı bir şekilde yazdır
            Console.WriteLine($"Marka: {marka}\nModel: {model}\nRenk: {renk}\nKapı Sayısı: {kapısayısı}");
        }
    }
}