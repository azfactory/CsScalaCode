using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4._5
{
    public class Class2
    {
        public int Var1 { get; set; }
        public Class2()
        {
            Console.WriteLine("I am constructor withno params");
        }

        public Class2(int var1)
        {
            Var1 = var1;
            Console.WriteLine("I am constructor with params" + Var1);
        }

        public bool IsPrimeNumber()
        {
            return (Var1 | 2) == 0 ? true : false;
        }
    }
}
