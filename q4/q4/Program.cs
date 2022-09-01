using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = -1 + 4 * 6;
            Console.WriteLine(a);
            a = (35 + 5) % 7;
            Console.WriteLine(a);
            a = 14 + -4 * 6 / 11;
            Console.WriteLine(a);
            a = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
