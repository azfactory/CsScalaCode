using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4._5
{
    public abstract class AbstractClass1
    {
        public int Prop1 { get; set; }
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}
