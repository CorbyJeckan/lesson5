using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drobi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RationalNumber num1 = new RationalNumber(1, 2);
            RationalNumber num2 = new RationalNumber(2, 3);

            Console.WriteLine("{num1} + {num2} = {num1 + num2}");

            Console.WriteLine(num1 < num2);
        }
    }
}
