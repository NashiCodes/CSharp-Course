namespace FullCourse.Inheritance;

internal abstract class Animal
{
    protected Animal(string name = "No Name", string sound = "No Sound", string owner = "No Owner",
        string familly = "No Familly")
    {
        Name = name;
        Sound = sound;
        Owner = owner;
        Familly = familly;
    }

    protected string Name { get; set; }
    protected string Sound { get; set; }
    protected string Owner { get; set; }
    protected string Familly { get; set; }

    internal abstract void MakeSound();

    internal abstract void PrintInfo();

    internal abstract void Move();

    internal abstract void stop();

    internal abstract void getFamilly();
}