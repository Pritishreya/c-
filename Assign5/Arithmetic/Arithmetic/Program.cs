using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0.06f;
            float y = 5.94f;
            Console.WriteLine("X=" + x);
            Console.WriteLine("Y=" + y);
            float Sum = x + y;
            Console.WriteLine("Print the sum of X & Y.");
            Console.WriteLine("Sum=" + Sum);
            Console.WriteLine("Print the summation of X & Y = 6  are equal or not. ");
            if (Sum == 6)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            Console.WriteLine("Print the which has greater value? X or y?");
            if (x > y)
                Console.WriteLine("X is greater!!");
            else
                Console.WriteLine("Y is greater!!");
        }
    }
}
