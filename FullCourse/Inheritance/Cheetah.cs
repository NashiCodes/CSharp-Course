namespace FullCourse.Inheritance;

internal class Cheetah : Animal
{
    public Cheetah(string name = "No Name", string owner = "No Owner") : base(name, "Roar, Roar!!", owner,
        "Acinonyx jubatus")
    {
    }

    internal override void MakeSound()
    {
        Console.WriteLine($"Cheetah {Name}, Owned by: {Owner}, says: \"{Sound}\"");
    }

    internal override void PrintInfo()
    {
        Console.WriteLine($"Cheetah {Name}");
        Console.WriteLine($"Owner: {Owner}");
        Console.WriteLine($"Sound: {Sound}");
        Console.WriteLine($"Familly: {Familly}");
    }

    internal override void Move()
    {
        Console.WriteLine($"Cheetah {Name} is running 120km/h");
    }

    internal override void stop()
    {
        Console.WriteLine($"Cheetah {Name} stopped, and now you can just wait for your death :(");
    }

    internal override void getFamilly()
    {
        Console.WriteLine($"Cheetah {Name} is from {Familly} familly");
    }
}