using System;
using System.Threading;
namespace AbdusSalam10
{
    public class StopWatch
     
    {
       public void Stopwatch()
       {
           for (int i = 0; i < 1000; i++)
	{
	    Thread.Sleep(1);
	}
     Stopwatch.Stop();

       }
       
    }
}