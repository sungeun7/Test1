using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Calculator
    {
        static void main(string[] args)
        {
            Console.WriteLine("Hello, world");
            int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }

        internal static double DoOperation(double cleanNum1, double cleanNum2, string op)
        {
            throw new NotImplementedException();
        }
    }
}
