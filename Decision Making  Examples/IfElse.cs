using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making__Examples
{
    class IfElse
    {
        public void IfElseMethod()
        {
            Console.WriteLine("Enter a number.");
            var getInput = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            //if(getInput >i || getInput < i || getInput == 0)
            //{
            //   for (int z = getInput; z > getInput; z++)
            //    {
            //        Console.WriteLine("Value Z:" +z);
            //    }

            //}

            for(int oneToTen = 1; oneToTen <= 10; oneToTen++)
            {
                int Sum = getInput + oneToTen;
                Console.WriteLine($"Value : {getInput} + {oneToTen} = {Sum}");
            }

           
            
        }
    }
}
