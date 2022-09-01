using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter 2 numbers : \nno1 : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("no2: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(a+"+"+b+"="+c);
            Console.ReadKey();
        }
    }
}
