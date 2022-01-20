using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making__Examples
{
    class WhileLoop
    {
        public void whileloop(int x)
        {

            while (x <= 10)
            {
                Console.WriteLine("Value: " + x);
                x++;
            }

        }
        public void DoWhile()
        {
            int a = 0;
            do
            {
                a++;
                Console.WriteLine("\nNumber :" + a);
            }
            while (a < 10);
        }
        public static void main (string[] args)
        {
            WhileLoop w = new WhileLoop();
            w.whileloop(1);
            int a = 1;
            do
            {
                a++;
                Console.WriteLine("Number :"+a);
            }
            while (a <= 10);
        }
    }
}
