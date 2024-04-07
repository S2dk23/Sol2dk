// See https://aka.ms/new-console-template for more information
class Rectangle : Shape, IShape
{
    public double width { get; set; }
    public double getArea()
    {
        return Length * width;
    }
}