using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite chislo ot kotorogo idet otschet");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite chislo do kotorogo idet otschet");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                Console.Write($"{i}, ");
            }
            Console.ReadKey();
        }
    }
}
