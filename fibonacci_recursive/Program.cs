using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_recursive

{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, y; //değişken oluştur
            Console.WriteLine("Bir sayı giriniz: "); //kullanıcıdan sayı iste
            sayi = Convert.ToInt32(Console.ReadLine()); // string'den integer'a çevir sayi değişkenine ata

            y = fibonacci(sayi); // fibonacci metot'unu çağır ve değeri y değişkenine ata
            Console.WriteLine(sayi + " e kadar fibonacci sayılar toplamı: " + y); // ekrana yazdır

            int fibonacci(int x) //metot
            {
                if (x == 0) //eğer x=0
                {
                    return 0; // 0 döndür
                }
                else if (x == 1) //ya da 1 ise 
                {
                    return 1; // 1 döndür
                }
                else // her ikisinden 1'i değilse
                {
                    return fibonacci(x - 1 ) + fibonacci(x - 2); // x-1 ve x-2 sayıları için metotu çağır
                }
            }
            Console.Read();//Bekle
        }
    }
}