using System.Diagnostics;

namespace Stop_Watch_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the stopwatch...");
            Console.ReadKey();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Stopwatch started. Press any key to stop...");
            Console.ReadKey();

            stopwatch.Stop();

            TimeSpan elapsedTime = stopwatch.Elapsed;

            Console.WriteLine("Elapsed Time: {0}", elapsedTime);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}