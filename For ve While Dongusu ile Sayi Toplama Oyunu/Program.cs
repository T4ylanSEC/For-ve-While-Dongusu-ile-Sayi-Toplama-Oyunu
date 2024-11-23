using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_ve_While_Dongusu_ile_Sayi_Toplama_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilar = new List<int>();
            int toplam = 0;

            Console.WriteLine("Pozitif Tam Sayılar Giriniz. Girişi Sonlandırmak İstiyorsanız 0 Giriniz.");

            while (true)
            {
                Console.Write("Sayı: ");
                if (!int.TryParse(Console.ReadLine(), out int sayi) || sayi < 0)
                {
                    Console.WriteLine("Geçerli Bir Pozitif Tam Sayı Giriniz.");
                    continue;
                }

                if (sayi == 0)
                    break;

                sayilar.Add(sayi);
                toplam += sayi;
            }

            Console.WriteLine($"\nGirilen Sayıların Toplamı: {toplam}");
            Console.WriteLine("Girilen Sayılar: ");

            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("Program Sonlandırıldı.");

            Console.ReadKey();

        }
    }
}