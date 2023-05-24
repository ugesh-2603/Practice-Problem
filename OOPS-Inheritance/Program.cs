namespace OOPS_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance is the process of acquiring all the properties of one class into another class.");

            // Creating an instance of the derived class
            Dog dog = new Dog();

            // Calling methods from the base class
            dog.Eat();
            dog.Sleep();

            // Calling method from the derived class
            dog.Bark();

            Console.ReadLine();
        }
    }

    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
}