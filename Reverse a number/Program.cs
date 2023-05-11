namespace Reverse_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int reversedNum = 0, remainder = 0;

            while (num != 0)
            {
                remainder = num % 10;
                reversedNum = (reversedNum * 10) + remainder;
                num /= 10;
            }

            Console.WriteLine($"Reversed Number: {reversedNum}");
        }
    }
}