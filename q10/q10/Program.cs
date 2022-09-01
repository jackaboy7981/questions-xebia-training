using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            float d;
            Console.Write("Enter the First number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Forth number: ");
            Console.Write("Result of specified numbers " + a + ", " + b + " and " + c + ", (x + y).z is " + ((a + b) * c) + " and x.y + y.z is" + (a * b + b * c));
            Console.ReadKey();
        }
    }
}
