using System;

// Inheritance and Method Overriding
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}
// 1st derived class
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}
// 2nd derived class
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Abstract Classes and Methods
abstract class Shape
{
    public abstract double GetArea();
}
// 1st derived class
class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}
// 2nd derived class
class Rectangle : Shape
{
    private double length;
    private double width;
    
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public override double GetArea()
    {
        return length * width;
    }
}

// Interfaces
interface IMovable
{
    void Move();
}
// 1st class implementing the interface
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
// 2nd class implementing the interface
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Inheritance and Method Overriding
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        // Abstract Classes and Methods
        Circle circle = new Circle(7.0);
        Rectangle rectangle = new Rectangle(5.0, 7.0);

        Console.WriteLine($"Circle area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        
        // Interfaces
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        
        car.Move();
        bicycle.Move();
    }
}