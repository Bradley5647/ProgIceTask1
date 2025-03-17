namespace shapeAreaCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making changes and commiting again
            //comments were not there before but are there now 
            Rectangle r = new Rectangle("Rectangle", 5, 10);

            r.Display();
            Console.WriteLine($"Area: {r.CalculateArea()}"); 

            Circle c = new Circle("Circle", 5);
            
            c.Display();
            Console.WriteLine($"Area: {c.CalculateArea()}");
        }
    }
}
