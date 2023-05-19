namespace Coupon_Number_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generating a random coupon number
            string couponNumber = GenerateCouponNumber();

            // Displaying the coupon number
            Console.WriteLine("Coupon Number: " + couponNumber);
        }

        static string GenerateCouponNumber()
        {
            // Define the characters that can be used in the coupon number
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Create an instance of the Random class
            Random random = new Random();

            // Generate a random coupon number of length 10
            char[] coupon = new char[10];
            for (int i = 0; i < 10; i++)
            {
                // Generate a random index to select a character from the characters string
                int index = random.Next(0, characters.Length);

                // Assigning the selected character to the couponArray at the current index
                coupon[i] = characters[index];
            }

            // Convert the char array to a string and return it as the coupon number
            return new string(coupon);
        }
    }
}