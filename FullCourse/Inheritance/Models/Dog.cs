namespace FullCourse.Inheritance.Models;

internal class Dog : Animal
{
    public Dog(string name = "No Name", string owner = "No Owner") : base(name, "Woof, Woof!!", owner,
        "Canis lupus familiaris")
    {
    }

    internal override void MakeSound()
    {
        Console.WriteLine($"Dog {Name}, Owned by: {Owner}, says: \"{Sound}\"");
    }

    internal override void PrintInfo()
    {
        Console.WriteLine($"Dog {Name}");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Sound: {Sound}");
        Console.WriteLine($"Familly: {Familly}");
    }

    internal override void Move()
    {
        Console.WriteLine($"Dog {Name} is running 10m/s");
    }

    internal override void stop()
    {
        Console.WriteLine($"Dog {Name} stopped, and now is waiting for you");
    }

    internal override void getFamilly()
    {
        Console.WriteLine($"Dog {Name} is from {Familly} familly");
    }
}