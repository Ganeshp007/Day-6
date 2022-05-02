using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Problems
{
    internal class SimulateWatch
    {
        public void  RunStopWatch()
        {
            
            Stopwatch stopWatch = new Stopwatch();//created new stopwatch class obj
         
            stopWatch.Start();
            
           for (int i = 1; i <= 200; i++) // i=100 ~= 1.5 sec
            {
                Thread.Sleep(1);
            }
   
            stopWatch.Stop();
          
            Console.WriteLine("Time Elapsed:{0}", stopWatch.Elapsed);


        }
    }
}
