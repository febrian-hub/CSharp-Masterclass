using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CSharpFundamentals
{
    internal class @out
    {
        public static void Main()
        {
            int a = 9;
            int b = 9;

            int sum, difference, product, quotient;
            Calculate(a, b, out sum, out difference, out product, out quotient);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");



        }
        public static void Calculate(int x, int y, out int sum, out int difference, out int product, out int quotient)
        {
            sum = x+y;
            difference = x - y;
            product = x * y;
            quotient = x / y;
        }
    }
}
