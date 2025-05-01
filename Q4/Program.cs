namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p   = new Product("Phone", 500.0 , 3);
            Console.WriteLine("Total cost (from fields): " + p.CalculateCost());
            Console.WriteLine("Total cost (from parameters): " + p.CalculateCost(450.0 ,2 ));
        }
    }
}
