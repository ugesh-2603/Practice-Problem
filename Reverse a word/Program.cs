namespace Reverse_a_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word, reversedWord = "";

            Console.Write("Enter a word: ");
            word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--) 
            {
                reversedWord += word[i];
            }

            Console.WriteLine("The reversed word is: " + reversedWord);
        }
    }
}