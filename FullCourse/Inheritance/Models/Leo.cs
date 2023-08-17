namespace FullCourse.Inheritance.Models;

internal class Leo : Animal
{
    public Leo(string name = "No Name", string owner = "No Owner") : base(name, "Roar, Roar!!", owner,
        "Panthera leo")
    {
    }

    internal override void MakeSound()
    {
        Console.WriteLine($"Leo {Name}, Owned by: {Owner}, says: \"{Sound}\"");
    }

    internal override void PrintInfo()
    {
        Console.WriteLine($"Leo {Name}");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Sound: {Sound}");
        Console.WriteLine($"Familly: {Familly}");
    }

    internal override void Move()
    {
        Console.WriteLine($"Leo {Name} is running 30m/s");
    }

    internal override void stop()
    {
        Console.WriteLine($"Leo {Name} stopped, and now is chasing you");
    }

    internal override void getFamilly()
    {
        Console.WriteLine($"Leo {Name} is from {Familly} familly");
    }
}