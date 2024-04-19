namespace MindboxTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5.0);
            Console.WriteLine($"Area of circle with radius 5: {circle.CalculateArea()}");

            var triangle = new Triangle(3.0, 4.0, 5.0);
            Console.WriteLine($"Area of triangle with sides 3, 4, 5: {triangle.CalculateArea()}");
            Console.WriteLine($"Is the triangle right-angled? {triangle.IsRightAngled()}");
        }
    }
}
