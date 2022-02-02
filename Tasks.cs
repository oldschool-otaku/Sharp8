using System;

namespace Sharp8
{
    public class Tasks
    {
        public static int Compare(int a, int b)
        {
            return a>b ? a : a<b ? b : 0;
        }

        public static int Change(ref int a, ref int b)
        {
            (b, a) = (a, b);

            Console.WriteLine(a);
            Console.WriteLine(b);
            return 0;
        }

        public static int Factorial(int number)
        {
            return number == 0 ? 1 : number * Factorial(number - 1);
        }

        public static int Fibonacci(int number)
        {
            return number switch
            {
                0 => 0,
                1 => 1
                ,
                _ => Fibonacci(number - 1) + Fibonacci(number - 2)
            };
        }
        
    }
}