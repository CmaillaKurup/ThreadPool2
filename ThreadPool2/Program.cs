using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadPool2
{
    class Program
    {
        //This code test the speed of both a Thread and Thread pool
        static void Main(string[] args)
        {
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Threat pool are executing here");
            
            mywatch.Start();
            
            ProcessWithThreadPoolMethod();
            mywatch.Stop();
            
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks);
            
            mywatch.Reset();
            
            Console.WriteLine("threats are executing here");
            
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();
            
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks);
            
        }

        static void Process(object obj)
        {
            
        }
        
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}