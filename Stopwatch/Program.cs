using System;
using System.Diagnostics;
using System.Threading;

namespace StopwatchProgram
{
    // 4. WAP for stopwatch

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Press S to start swapwatch.");
            var getInput = Console.ReadLine();
            if (getInput == "s")
            {
                stopWatch.Start();
            }
            else
            {
                Console.WriteLine("Wrong input. Press S to start swapwatch.");
            }

            Console.WriteLine("Press t to stop swapwatch.");
            var getInput2 = Console.ReadLine();
            if (getInput2 == "t")
            {
                stopWatch.Stop();
            }
            else
            {
                Console.WriteLine("Wrong input. Press t to top swapwatch.");
            }

            //Thread.Sleep(10000);
            
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            #region
            //Stopwatch sw = new Stopwatch();
            //Console.WriteLine("Press S to start swapwatch.");
            //var getInput = Console.ReadLine();
            //if(getInput == "s")
            //{
            //    sw.Start();
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input. Press S to start swapwatch.");
            //}

            //for(int i = 0; i<10;i++)
            //{
            //    Console.WriteLine("Start");
            //}
            //Console.WriteLine("Press t to stop swapwatch.");
            //var getInput2 = Console.ReadLine();
            //if (getInput2 == "t")
            //{
            //    sw.Start();
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input. Press t to top swapwatch.");
            //}
            #endregion
        }
    }
}
