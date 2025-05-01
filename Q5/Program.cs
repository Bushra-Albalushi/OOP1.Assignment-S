using System.Xml.Linq;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee details:");

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee(name, age, salary);

           
            Console.Write("How many times do you want to print the details? ");
            int repeat = int.Parse(Console.ReadLine());


        }
    }
}

