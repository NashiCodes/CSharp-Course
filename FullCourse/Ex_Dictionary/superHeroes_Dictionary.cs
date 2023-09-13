namespace FullCourse.Ex_Dictionary;

public class superHeroes_Dictionary
{
    public static void main()
    {
        var superheroes = new Dictionary<string, string>
        {
            { "Clark Kent", "Superman" },
            { "Bruce Wayne", "Batman" },
            { "Barry West", "Flash" },
            { "Peter Parker", "Spiderman" },
            { "Steve Rogers", "Captain America" },
            { "Tony Stark", "Iron Man" }
        };

        superheroes.Remove("Barry West");

        Console.WriteLine("Count: {0}", superheroes.Count);

        Console.WriteLine("Clark Kent: {0}", superheroes.ContainsKey("Clark Kent"));
        Console.WriteLine("Barry West: {0}", superheroes.ContainsKey("Barry West"));

        superheroes.TryGetValue("Clark Kent", out var test);
        Console.WriteLine("Clark Kent: {0}", test);

        foreach (var item in superheroes) Console.WriteLine("{0}: {1}", item.Key, item.Value);

        superheroes.Clear();

        Console.WriteLine("Count: {0}", superheroes.Count);
    }
}