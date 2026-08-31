using GeometricFigure.Backend;

var circle = new Circle(name: nameof(Circle), r: 5);
var square = new Square(name: nameof(Square), a: 10);
var rhombus = new Rhombus(name: nameof(Rhombus), a: 5, d1: 7, d2: 10);
var kite = new Kite(name: nameof(Kite), a: 7, b: 8, d1: 6, d2: 5);
var rectangle = new Rectangle(name: nameof(Rectangle), a: 4.568, b: 67.790);
var parallelogram = new Parallelogram(name: nameof(Parallelogram), a: 14.65, b: 54.67, h: 23.09);
var triangle = new Triangle(name: nameof(Triangle), a: 45.56, b: 12.34, c: 27.09, h: 15);
var trapeze = new Trapeze(name: nameof(Trapeze), a: 10, b: 20, c: 30, d: 40, h: 20);

var figures = new List<GeometricFigure>
{
    circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze
};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}

internal class GeometricFigure
{
}

internal class Trapeze
{
    private string name;
    private int a;
    private int b;
    private int c;
    private int d;
    private int h;

    public Trapeze(string name, int a, int b, int c, int d, int h)
    {
        this.name = name;
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.h = h;
    }
}

private class Triangle
{
    private string name;
    private double a;
    private double b;
    private double c;
    private int h;

    public Triangle(string name, double a, double b, double c, int h)
    {
        this.name = name;
        this.a = a;
        this.b = b;
        this.c = c;
        this.h = h;
    }
}

private class Parallelogram
{
    private string name;
    private double a;
    private double b;
    private double h;

    public Parallelogram(string name, double a, double b, double h)
    {
        this.name = name;
        this.a = a;
        this.b = b;
        this.h = h;
    }
}

internal class Rectangle
{
    private string name;
    private double a;
    private double b;

    public Rectangle(string name, double a, double b)
    {
        this.name = name;
        this.a = a;
        this.b = b;
    }
}

internal class Kite
{
    private string name;
    private int a;
    private int b;
    private int d1;
    private int d2;

    public Kite(string name, int a, int b, int d1, int d2)
    {
        this.name = name;
        this.a = a;
        this.b = b;
        this.d1 = d1;
        this.d2 = d2;
    }
}

internal class Rhombus
{
    private string name;
    private int a;
    private int d1;
    private int d2;

    public Rhombus(string name, int a, int d1, int d2)
    {
        this.name = name;
        this.a = a;
        this.d1 = d1;
        this.d2 = d2;
    }
}

internal class Square
{
    private string name;
    private int a;

    public Square(string name, int a)
    {
        this.name = name;
        this.a = a;
    }
}

internal class Circle
{
    private string name;
    private int r;

    public Circle(string name, int r)
    {
        this.name = name;
        this.r = r;
    }
}