using System;

namespace ClassLibrarySample
{
    public class MathOperations
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public MathOperations(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public void Sum()
        {
            Console.WriteLine("Sum of Number : " + (Number1 + Number2));
        }
        public void Difference()
        {
            Console.WriteLine("Sum of Number : " + (Number1 - Number2));
        }
        public void Product()
        {
            Console.WriteLine("Sum of Number : " + (Number1 * Number2));
        }
        public void Division()
        {
            try
            {
                Console.WriteLine("Sum of Number : " + (Number1 / Number2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
