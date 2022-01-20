using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Constructor_OverLoadingcs
    {
        public Constructor_OverLoadingcs(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"Sum is: {sum} ");
        }

        public Constructor_OverLoadingcs(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine($"The sum is : {sum}");
        }
    }
}
