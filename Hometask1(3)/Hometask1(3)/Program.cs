using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite kolichestvo stolbov");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite dlinu mezhdu stolbami (v metrah)");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite shirinu stolba (v sm)");
            decimal n = decimal.Parse(Console.ReadLine());
            decimal Length = 0;
            for (int i = 0; i <= k; i++)
            {
                Length = (((l * 100 * (k - 1)) + (k * n)) - (2 * n));
            }
            Console.WriteLine($"dlina mezhdu pervim i posl stolbom {Length} cm");
            Console.ReadKey();
        }
    }
}
