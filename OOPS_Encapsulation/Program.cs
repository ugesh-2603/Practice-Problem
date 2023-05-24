namespace OOPS_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation protect important data inside the class which we do not want to be exposed outside the class.");
            Employee employee = new Employee();

            Console.Write("Enter employee name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Enter employee age: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            employee.Age = age;

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Age: " + employee.Age);

        }
    }

    public class Employee
    {
        private string name; //string
        private int age;     //int

        public string Name
        {
            get { return name; }  // getting the value from the user.
            set { name = value; } // setting the value entered by the user in the name.
        }

        public int Age
        {
            get { return age; }  //// getting the value from the user
            set { age = value; } //// // setting the value entered by the user in the age.
        }
    }
}
