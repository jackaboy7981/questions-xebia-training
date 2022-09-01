using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("Enter 2 numbers : \nInput the first number to multiply: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Third number to multiply: ");
            c = Convert.ToInt32(Console.ReadLine());
            d = a * b * c;
            Console.WriteLine(a + "x" + b + "x" + c+" = "+d );
            Console.ReadKey();
        }
    }
}
