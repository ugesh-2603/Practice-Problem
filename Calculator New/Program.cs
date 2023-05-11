namespace Calculator_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator App");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operation ((Addition) +, (Subtraction) -, (Multiplication) *, (Division) /):");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine("Result: " + result);
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }
}