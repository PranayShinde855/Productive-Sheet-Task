using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making__Examples
{
    class ForEachLoop
    {
        public void ForEachLoopPractice()
        {
            //Console.WriteLine("Enter a number");
            //int getInput = Convert.ToInt32(Console.ReadLine());
            int[] array = { 1, 3, 4, 5, 6, 7 };

            for (int i = 1; i <= 2; i++)


            foreach (var num in array)
            {
                    //Console.WriteLine("Variable in array :" + num);
                    int sum = num + i;
                    Console.WriteLine("Values : "+sum);
            }
        }
    }
}
