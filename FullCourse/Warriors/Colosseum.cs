namespace FullCourse.Warriors;

internal class Colosseum
{
    public static void battle()
    {
        var maximus = new Warrior("Maximus", 2000, 220, 70);
        var persian = new Warrior("Persian", 1600, 200, 140);
        var spartacus = new Warrior("Spartacus", 1800, 200, 80);
        var alexander = new Warrior("Alexander", 1500, 220, 100);
        var leonidas = new Warrior("Leonidas", 2000, 250, 50);
        var achilles = new Warrior("Achilles", 2500, 150, 90);
        var hector = new Warrior("Hector", 1800, 200, 100);
        var ajax = new Warrior("Ajax", 1900, 210, 100);

        var warriors = new List<Warrior> { maximus, persian, spartacus, alexander, leonidas, achilles, hector, ajax };

        var rnd = new Random();

        while (warriors.Count > 1)
        {
            var warrior1 = warriors[rnd.Next(0, warriors.Count)];
            warriors.Remove(warrior1);
            var warrior2 = warriors[rnd.Next(0, warriors.Count)];
            warriors.Remove(warrior2);

            Console.WriteLine("<--------------------------------->");
            Console.WriteLine($"{warrior1.Name} vs {warrior2.Name}");
            Console.WriteLine("Figth!");
            Console.WriteLine("<--------------------------------->");
            Console.WriteLine();


            var winner = Battle.StartFight(warrior1, warrior2);
            Console.WriteLine($"{winner.Name} is the Winner");

            winner.heal();

            warriors.Add(winner);

            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("<--------------------------------->");
        Console.WriteLine($"{warriors[0].Name} is the Champion");
        Console.WriteLine("<--------------------------------->");
    }
}