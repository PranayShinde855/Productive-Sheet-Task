using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad_Override
{
    class Method_Overloading
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public static void Main(string[] args)
        { 
            Method_Overloading exampleOveroading = new Method_Overloading();
            var Addition1 = exampleOveroading.Add(1,2);
            Console.WriteLine($"Sum :{Addition1}");
            var Addition2 = exampleOveroading.Add(2,4,5);
            Console.WriteLine("Sum :"+Addition2);
        }
    }
}
