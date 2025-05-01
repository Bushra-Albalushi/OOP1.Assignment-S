namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Calculator calc = new Calculator();
            Console.WriteLine("Sum of 5 and 10: " + calc.Add(5, 10));
            Console.WriteLine("Sum of 5, 10, and 15: " + calc.Add(5, 10, 15));
        }
    }
}
