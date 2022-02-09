using System;
using System.Collections;

namespace Stack_Implementation
{
    // Stack in last-in, first-out collection object
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //Adding element to stack
            stack.Push("Last");
            stack.Push(12.00);
            stack.Push(2);
            stack.Push("Pranay");
            stack.Push(4);
            stack.Push(null);
            stack.Push("first");

            foreach(var e in stack)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("");
            // Diasplay ements at begning of stacks
            Console.WriteLine(stack.Peek());
            Console.WriteLine("");
            //Removing element from stack
            stack.Pop();
            foreach (var e in stack)
            {
                Console.WriteLine(e);
            }

        }
    }
}
