// See https://aka.ms/new-console-template for more information



Console.Write("Enter Lenght:");
var length = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Width:");
var width = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Height:");
var height = Convert.ToInt32(Console.ReadLine());



var cube = new Cube(width, length, height);
var triangle = new Triangle();
var triangle1 = new Triangle() { Length = length, Height = height, Hypotenuese = 10 };
var triangle2 = new Triangle(10);
var triangle3 = new Triangle(10, height, length);

var rectangle = new Rectangle() { width = width, Length = length };



Console.WriteLine("cube Area is: " + cube.getArea());
Console.WriteLine("cube Volume is: " + cube.getVolume());

Console.WriteLine("Triangle Area is: " + triangle.getArea());
Console.WriteLine("Triangle Area is: " + triangle1.getArea());
Console.WriteLine("Triangle Area is: " + triangle2.getArea());
Console.WriteLine("Triangle Area is: " + triangle3.getArea());

Console.WriteLine("Rectangle Area is: " +  rectangle.getArea()); 