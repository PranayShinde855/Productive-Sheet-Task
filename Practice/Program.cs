using System;

namespace Practice
{
    public class Test
    {
        public string ValueString { get; set; }
    }
   public class Program
    {
        public static void ChangeValueType(Test test)
        {
            test.ValueString = "Test1";
        }
        static void Main(string[] args)
        {
            String str2= "sp";
            string str3 = "string3";
            var i = 10;
            Console.WriteLine("Type of i is {0}", i.GetType());
            Console.WriteLine(str2 + str3);
            Console.WriteLine("Hello World!");

            Test t1 = new Test();
            t1.ValueString = "Test";
            ChangeValueType(t1);
            Console.WriteLine(t1.ValueString);

        }
    }
}
