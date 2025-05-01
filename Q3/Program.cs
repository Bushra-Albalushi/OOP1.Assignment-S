namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Rooh", 28);
            p.PrintInfo();
            p.PrintInfo(1);
        }
    }
}
