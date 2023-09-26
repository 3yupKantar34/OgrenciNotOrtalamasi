using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vize, final;
            float ort;

            Console.Write("Vize notunuzu giriniz: ");
            vize = int.Parse(Console.ReadLine());

            while (vize > 100 || vize < 0)
            {
                Console.WriteLine("Vize notunuz 0 ile 100 arasında olmalıdır.");
                Console.Write("Vize notunuzu giriniz: ");
                vize = int.Parse(Console.ReadLine());
            }

            Console.Write("Final notunuzu giriniz: ");
            final = int.Parse(Console.ReadLine());

            while (final > 100 || final < 0)
            {
                Console.WriteLine("Final notunuz 0 ile 100 arasında olmalıdır.");
                Console.Write("Final notunuzu giriniz: ");
                final = int.Parse(Console.ReadLine());
            }

            ort = (float)(vize * 0.4 + final * 0.6);

            if (ort >= 84.5 && ort <= 100)
                Console.WriteLine($"Not ortalamanız {ort:F1} - Notunuz 'AA'");
            else if (ort >= 69.5 && ort < 84.5)
                Console.WriteLine($"Not ortalamanız {ort:F1} - Notunuz 'BB'");
            else if (ort >= 59.5 && ort < 69.5)
                Console.WriteLine($"Not ortalamanız {ort:F1} - Notunuz 'CC'");
            else if (ort >= 49.5 && ort < 59.5)
                Console.WriteLine($"Not ortalamanız {ort:F1} - Notunuz 'DD'");
            else
                Console.WriteLine($"Not ortalamanız {ort:F1} - Notunuz 'FF'");
            Console.ReadLine();
        }
    }
}
