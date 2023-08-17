namespace FullCourse.Inheritance.Models;

internal class Cat : Animal
{
    public Cat(string name = "No Name", string owner = "No Owner") : base(name, "Meow, Meow!!", owner,
        "Felis catus")
    {
    }

    internal override void MakeSound()
    {
        Console.WriteLine($"Cat {Name}, Owned by: {Owner}, says: \"{Sound}\"");
    }

    internal override void PrintInfo()
    {
        Console.WriteLine($"Cat {Name}");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Sound: {Sound}");
        Console.WriteLine($"Familly: {Familly}");
    }

    internal override void Move()
    {
        Console.WriteLine($"Cat {Name} is running 15m/s");
    }

    internal override void stop()
    {
        Console.WriteLine($"Cat {Name} doesn't obey you");
    }

    internal override void getFamilly()
    {
        Console.WriteLine($"Cat {Name} is from {Familly} familly");
    }
}