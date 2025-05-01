using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Person
    {
        private string name;
        private int age;
        public Person( string Name, int age)
        {
            this.name = Name;
            this.age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name:" + name , "Age:" +age);
        }
        public void PrintInfo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Name:" + name , "Age:" +age);
            }
        }
            
        

    }
}
