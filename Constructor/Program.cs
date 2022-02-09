using System;

namespace Constructor
{
    class Program
    { //  1. Write a program to demostrate use of constructors
      //  2. Write a program to demostrate use of constructor overloading


        static void Main(string[] args)
        {
            Addition add = new Addition(4, 5);
            add.method(5, 7);
            add.method(67, 89);

            Constructor_OverLoadingcs c1 = new Constructor_OverLoadingcs(1,2);
            Constructor_OverLoadingcs c2 = new Constructor_OverLoadingcs(1,2,3);

        }
    }

    public class Addition
    {
        public Addition(int a, int b)
        {
            Console.WriteLine("Enter first element :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second element");
            b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("The sum of elements is : "+b);
        }

        public void method(int a, int b)
        {
           int c = a + b;
            Console.WriteLine("The sum of elements is :" +c);
        }
    }
}
