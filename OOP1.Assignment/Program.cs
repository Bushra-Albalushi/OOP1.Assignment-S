namespace OOP1.Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine("Area (from fields): rectangle.CalculateArea()");
            Console.WriteLine("Area (from parameters): rectangle.CalculateArea(7,3)");
        }
    }
}
