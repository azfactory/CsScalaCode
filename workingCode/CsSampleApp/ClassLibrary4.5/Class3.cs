using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4._5
{
    public class Class3 : Interface1
    {
        public Class3(int prop1, int prop2)
        {
            Prop1 = prop1 * 5;
            Prop2 = prop2;
        }
        public int Prop1 { get; set; }
        public int Prop2 { get; set; }

        public void Func1()
        {
            Console.WriteLine("Value of Property1= " + Prop1);
        }
    }
}
