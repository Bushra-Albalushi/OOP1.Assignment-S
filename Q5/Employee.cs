
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Employee
    {
      
        string name;
        int age;
        double salary;

    public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public void printDetails()
        {
        printDetails(1);
        }
        public void printDetails(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Name: " + name + ", Age: " + age + ", Salary: " + salary);
            }
        }
        
    }
}
