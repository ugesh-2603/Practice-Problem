using System.Drawing;

namespace OOPS_Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Polymorphism allows a class to have multiple implementations with the same name.");

            // Creating an array of shapes
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape();
            shapes[1] = new Circle();
            shapes[2] = new Rectangle();

            // Iterating over the array and calling the Draw() method
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
    }

    // Base class
    class Shape
    {
        public virtual void Draw() // virtual means implementation can be modified in a derived class to provide different behavior.
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    // Derived class 1
    class Circle : Shape
    {
        public override void Draw() // Override mean it is only applicable when the class containing this method is derived from another class.
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // Derived class 2
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle.");
        }
    }

}