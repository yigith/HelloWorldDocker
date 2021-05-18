using System;
using System.Threading;

namespace HelloWorldDocker
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString() + " (" + i++ + ")");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
