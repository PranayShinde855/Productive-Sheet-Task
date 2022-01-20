using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making__Examples
{
    class Multipliction_Table
    {
        public void MultiPlication()
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10;j++)
                {
                    int mutli = i * j;
                    Console.WriteLine(+mutli);
                }
            }
        }
    }
}
