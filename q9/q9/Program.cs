using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            float e;
            Console.Write("Enter the First number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Forth number: ");
            d = Convert.ToInt32(Console.ReadLine());
            e =(float) (a + b + c + d) / 4;
            Console.Write("The average of "+a+ " , " + b + " , " + c + " , " + d + " is: "+ e);
            Console.ReadKey();
        }
    }
}
