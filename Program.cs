using System;

namespace Sharp8
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            
            Console.WriteLine(Tasks.Compare(a, b));
            Console.WriteLine(Tasks.Factorial(5));
            Console.WriteLine(Tasks.Fibonacci(13));
            Console.WriteLine(Tasks.Change(ref a, ref b));
        }
    }
}