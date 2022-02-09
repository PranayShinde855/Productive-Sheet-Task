using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilder_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<string>();
            list.Add("Digvijay");
            list.Add("Pranay");
            list.Add("Ajay");

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i <=3; i++)
            {
                builder.Append(i).Append("");
            }

            Console.WriteLine(builder+ "1");
        }
    }
}
