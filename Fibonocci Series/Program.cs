namespace Fibonocci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci_Series(5); // 5 means fibonocci series with till 5th element
        }

        static void Fibonacci_Series(int n)
        {
            int firstnumber = 0;
            int secondnumber = 1;

            Console.WriteLine("Fibonacci Series:");
            Console.Write(firstnumber + " " + secondnumber);

            for (int i = 2; i < n; i++)
            {
                int next = firstnumber + secondnumber;
                Console.Write(" " + next);
                firstnumber = secondnumber;
                secondnumber = next;
            }
        }
    }
}
