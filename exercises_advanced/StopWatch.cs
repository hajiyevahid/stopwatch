
using System;
using System.Globalization;
namespace exercises_advanced

{
    public class StopWatch
    {
        public  DateTime Current ;
        public  DateTime Current1 ;
        public TimeSpan interval;
        public bool f = false;
        
        public DateTime giveMeTime()
        {
            return DateTime.Now;
        }
        public Boolean State()
        {
            return this.f;
        }
        public void Start()
        {
            this.f = true;
            Current = this.giveMeTime();
            Console.Write("Current start time is : " + Current );
        }


        public void Stop()
        {
            this.f = false;
            Current1 = this.giveMeTime();
            interval = Current1 - Current;
            Console.WriteLine("Current end time is :" + Current1);
            Console.WriteLine("Stopwatch time duration = " + interval);
        }

    }
}
