using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerDelegate method = MethodForTesting;
            Timer timer = new Timer(method, 2);
            timer.Start();
        }

        static void MethodForTesting()
        {
            Console.WriteLine("This method is called every 2 seconds");
        }
    }
}
