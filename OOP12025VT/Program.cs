namespace OOP12025VT;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var cat = new Cat();
        var dog = new Dog(10.0);

        var animals = new List<Animal> { cat, dog };

        foreach (var animal in animals)
        {
            
        }

    }
}

abstract class Animal
{
    public Animal(double weight)
    {
        Weight = weight;
    }

    public double Weight { get; } 
}

class  Cat : Animal
{
    public double PurrVolume { get; }

    public Cat() : base(4.5)
    {
        PurrVolume = Weight * 0.5;
    }
}

class Dog : Animal
{
    public Dog(double weight) : base(weight)
    {

    }
}