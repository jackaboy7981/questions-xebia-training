using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("Enter 2 numbers : \nInput the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(a + "+" + b + "=" + c);
            c = a - b;
            Console.WriteLine(a + "-" + b + "=" + c);
            c = a * b;
            Console.WriteLine(a + "x" + b + "=" + c);
            if (b == 0)
            {
                Console.WriteLine("error: division by 0");
            }
            else
            {
                c = a / b;
                Console.WriteLine(a + "/" + b + "=" + c);
                c = a % b;
                Console.WriteLine(a + "mod" + b + "=" + c);
            }
            Console.ReadKey();
        }
    }
}
