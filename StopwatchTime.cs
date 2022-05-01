using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class StopwatchTime
    {
        public static void Elapsed()
        {
            //Creating new stopwatch object 
            Stopwatch stopwatch = new Stopwatch();
            //Setting start timming of stopwatch by calling method Start();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            //Setting stop timming of stopwatch by calling method Stop();
            stopwatch.Stop();
            Console.WriteLine("Time elapsed:{0}", stopwatch.Elapsed);
        }
    }
}
