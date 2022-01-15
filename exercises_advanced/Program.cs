using System;

namespace exercises_advanced
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            var input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Start" && stopwatch.State() == false)
                {

                   
                    stopwatch.Start();
                    Console.WriteLine();
                    Console.WriteLine("******************************************************");
                }
                else if (input == "Stop")
                {

                    stopwatch.Stop();
                    Console.WriteLine("Stopped");
                }


                else if(input == "Start" && stopwatch.State() == true)
                {
                    Console.WriteLine("Please stop the timer for starting again !");
                }

            }                  
        }
    }
}
