public class Rectangle : Shape
{
    private double _width;
    private double _height;

    // Constructor to initialize color, width, and height
    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}