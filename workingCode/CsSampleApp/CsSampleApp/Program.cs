using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrarySample;

namespace CsSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            MathOperations mo = new MathOperations(1, 8);
            mo.Sum();
            mo.Difference();
            mo.Product();
            mo.Division();
        }
    }
}
