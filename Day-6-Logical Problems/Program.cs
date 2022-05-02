// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("---- Welcome to Stopwatch Simulation ----\n");

Stopwatch stopWatch = new Stopwatch();//created new stopwatch obj

stopWatch.Start();

for (int i = 1; i <= 200; i++)// i=100 ~= 1.5 sec
{
    Thread.Sleep(1);
}

stopWatch.Stop();

Console.WriteLine("Time Elapsed:{0}", stopWatch.Elapsed);
