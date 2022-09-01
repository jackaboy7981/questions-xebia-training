using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Input the First Number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number :");
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping :\nFirst Number : " + a + "\nSecond Number : " + b);
            Console.ReadKey();
        }
    }
}
