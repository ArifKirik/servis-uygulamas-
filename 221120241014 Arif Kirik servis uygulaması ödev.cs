using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> ogrenciler = new List<string>();
        Console.WriteLine("Öğrenci bilgisi girmek için bir ad girin. İşlemi bitirmek için '9' yazın:");

        while (true)
        {
            Console.Write("Öğrenci Adı: ");
            string giris = Console.ReadLine();

            if (giris == "9")
            {
                break;
            }

            ogrenciler.Add(giris);
        }

        Console.WriteLine("Kaç öğrenciniz var?");
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Girdiğiniz toplam öğrenci sayısı: {ogrenciler.Count}");

        if (ogrenciler.Count > sayi)
        {
            Console.WriteLine("Olur.");
        }
        else
        {
            Console.WriteLine("Olmaz.");
        }
    }
}
