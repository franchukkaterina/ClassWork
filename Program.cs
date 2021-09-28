using System;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
           Fraction drob1=new Fraction(2,3);
           Fraction drob2=new Fraction(3,3);
           Console.WriteLine($"{drob1<drob2}");
           Console.WriteLine($"{drob1==drob2}");
           Console.WriteLine($"{drob1+drob2}");
        }
    }
}
