using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdditionClass.Addition();
            AdditionClass.Addition(3,5);
        }
    }

    public static class AdditionClass
    {
        public static void Addition()
        {
            int a = 65;
            int b = 78;
            int sum = a + b;
            Console.WriteLine("Sum of values: " +sum);
        }

        public static void Addition(int d, int e)
        {
            int sum = d + e;
            Console.WriteLine($"Sum of values is {sum}");
        }
    }
}
