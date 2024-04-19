namespace MindboxTask1
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius) => 
            _radius = radius;

        public double CalculateArea() =>
            Math.PI * _radius * _radius;
    }
}
