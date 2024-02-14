using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İstediğiniz kahve numarasını tuşlayınız?");
            Console.WriteLine("1: Latte");
            Console.WriteLine("2: Cappucino");
            Console.WriteLine("3: Americano");
            Console.WriteLine("4: Espresso");
            Console.WriteLine("5: Türk kahvesi");
            String secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("Latte seçtiniz, ücret: 16 PB");
                    break;
                case "2":
                    Console.WriteLine("Cappucino seçtiniz, ücret: 16 PB");
                    break;
                case "3":
                    Console.WriteLine("Americano seçtiniz, ücret: 14 PB");
                    break;
                case "4":
                    Console.WriteLine("Espresso seçtiniz, ücret: 12 PB");
                    break;
                case "5":
                    Console.WriteLine("Türk Kahvesi seçtiniz, ücret: 15 PB");
                    break;
                default:
                    Console.WriteLine("Yanlış tuşa bastınız, tekrar deneyiniz.");
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
