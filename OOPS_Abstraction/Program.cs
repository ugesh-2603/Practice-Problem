namespace OOPS_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction is the process of hiding certain details and showing only essential information to the user.");
            
            // Creating instances of the derived classes
            Animal dog = new Dog();
            Animal cat = new Cat();

            // Calling the MakeSound() method
            dog.MakeSound();
            cat.MakeSound();

            Console.ReadLine();
        }
    }

    // Abstract class
    abstract class Animal
    {
        public abstract void MakeSound();
    }

    // Derived class 1
    class Dog : Animal
    {
        public override void MakeSound() // Override mean it is only applicable when the class containing this method is derived from another class.
        {
            Console.WriteLine("Dog barks.");
        }
    }

    // Derived class 2
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }
}