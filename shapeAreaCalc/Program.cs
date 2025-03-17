namespace shapeAreaCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Rectangle", 5, 10);

            r.Display();
            Console.WriteLine($"Area: {r.CalculateArea()}"); 

            Circle c = new Circle("Circle", 5);
            
            c.Display();
            Console.WriteLine($"Area: {c.CalculateArea()}");
        }
    }
}
