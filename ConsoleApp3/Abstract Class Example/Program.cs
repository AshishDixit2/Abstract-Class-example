using System;

// Abstract class
abstract class Shape
{
    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();
}

// Concrete class: Circle
class Circle : Shape
{
    private double radius;
                                                                                                                                                                                                                                                                                                                                                                                                         
    // Constructor
    public Circle(double radius)                                                  
    {
        this.radius = radius;
    }
                                                                                                   
    // Implementation of abstract methods
    public override double CalculateArea()                  
    {
        return Math.PI * radius * radius;
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

// Concrete class: Rectangle
class Rectangle : Shape
{
    private double length;
    private double width;

    // Constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implementation of abstract methods
    public override double CalculateArea()
    {
        return length * width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());

        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());
    }
}