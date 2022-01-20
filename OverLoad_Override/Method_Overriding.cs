using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad_Override
{
    class Method_Overriding_Base
    {
        public void Display()
        {
            Console.WriteLine("Override example. Base Class");
        }

        public virtual void Override_Method()
        {
            Console.WriteLine("Override example. Base Class. 'Virtual' Keyword.");
        }
    }
    class Method_Overriding_Derived : Method_Overriding_Base
    {
        new void Display()
        {
            Console.WriteLine("Override example. Dervied Class");
        }

        public override void Override_Method()
        {
            Console.WriteLine("Override example. Base Class. 'override' Keyword.");
        }
    }

    class MainClass
    {
        public static void main(string[] args)
        {
            Method_Overriding_Base base1 = new Method_Overriding_Base();
            base1.Display();

            Method_Overriding_Derived dervied1 = new Method_Overriding_Derived();
            dervied1.Display();


            Method_Overriding_Base base2 = new Method_Overriding_Base();
            base2.Override_Method();

            Method_Overriding_Derived dervied2 = new Method_Overriding_Derived();
            dervied2.Override_Method();
        }
    }
}
