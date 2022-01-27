using System;

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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
