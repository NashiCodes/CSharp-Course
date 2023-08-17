using FullCourse.Inheritance.Models;

namespace FullCourse.Inheritance;

public class Safari
{
    public static void main()
    {
        var dog = new Dog("Rex", "John");
        var leo = new Leo("Simba", "John");
        var cat = new Cat("Tom", "John");
        var cheetah = new Cheetah("Cheetah", "John");

        dog.PrintInfo();
        dog.MakeSound();
        dog.Move();
        dog.stop();
        dog.getFamilly();

        Console.WriteLine();

        leo.PrintInfo();
        leo.MakeSound();
        leo.Move();
        leo.stop();
        leo.getFamilly();

        Console.WriteLine();

        cat.PrintInfo();
        cat.MakeSound();
        cat.Move();
        cat.stop();
        cat.getFamilly();

        Console.WriteLine();

        cheetah.PrintInfo();
        cheetah.MakeSound();
        cheetah.Move();
        cheetah.stop();
        cheetah.getFamilly();

        Console.WriteLine();
    }
}