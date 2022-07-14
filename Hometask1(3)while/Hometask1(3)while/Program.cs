using System;

namespace MyApp // Note: actual namespace depends on the project name.
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
            int i = 0;
            while (i < k)
            {
                Length = (((l * 100 * (k - 1)) + (k * n)) - (2 * n));
                i++;
            }
            Console.WriteLine($"dlina mezhdu pervim i posl stolbom {Length} cm");
            Console.ReadKey();
        }
    }
}
