namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                // Loop from 2 to the square root of the number
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    // If the number is divisible by any other number, it is not prime
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}