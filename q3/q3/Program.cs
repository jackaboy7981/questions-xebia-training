using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float c;
            Console.Write("Enter 2 numbers : \nno1 : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("no2: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b!=0)
            {
            c = a / b;
            Console.WriteLine(a + "/" + b + "=" + c);
            }
            else
            {
                Console.WriteLine("Division not possible as divisor = 0");
            }
            Console.ReadKey();
        }
    }
}
