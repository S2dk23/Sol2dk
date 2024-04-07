// See https://aka.ms/new-console-template for more information
class Cube : Shape
{

    public Cube(int width, int height, int length)
    {
        Width = width;
        Length = length;
        Height = height;
    }
    public double Width {  get; set; }

    public double getArea()
    {
        return Length * Length;
    }

    public double getVolume()
    {
        return Length * Width * Height;
    }
}