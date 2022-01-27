#define hello  
using System;
using System.Diagnostics;

namespace CalculatorApp
{
    public class Calculator
    {
        public Calculator() { }
        public int Add(int a, int b) {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {

        [Obsolete("display1 is deprecated, use display2", false)]
        public void display1()
        {
            Console.WriteLine("Visual Studio 2008");
        }
        public void display2()
        {
            Console.WriteLine("Visual Studio 2015");
        }
        [Conditional("hello")]
        public void print()
        {
            Console.WriteLine("Happy coding...");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.print();
            Console.Read();

            Console.WriteLine("Hello World!");
        }
    }
}
