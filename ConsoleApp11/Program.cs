using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractions fractions = new Fractions(5, 12);
            Console.WriteLine(fractions);
            Fractions fractions2 = new Fractions(5, 0);
            Console.WriteLine( fractions2);
        }
    }
}
