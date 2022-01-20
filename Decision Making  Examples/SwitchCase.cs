using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making__Examples
{
    class SwitchCase
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter any number from 1 to 5.");
            int getInput = Convert.ToInt32(Console.ReadLine());
            switch (getInput)
            {
                case 1:
                    Console.WriteLine("Performance = Poor");
                    break;
                case 2:
                    Console.WriteLine("Performance = Average");
                    break;
                case 3:
                    Console.WriteLine("Performance = Good");
                    break;
                case 4:
                    Console.WriteLine("Performance = Best");
                    break;
                case 5:
                    Console.WriteLine("Performance = Excellent");
                    break;
            }
        }
    }
}
