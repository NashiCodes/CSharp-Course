namespace FullCourse.Warriors;

internal class Battle
{
    public static Warrior StartFight(Warrior warrior1, Warrior warrior2)
    {
        while (true)
        {
            if (GetAttackResult(warrior1, warrior2) == "Game Over")
                return warrior1;

            if (GetAttackResult(warrior2, warrior1) == "Game Over")
                return warrior2;
        }
    }

    private static string GetAttackResult(Warrior warriorA, Warrior warriorB)
    {
        var warriorAAttackAmount = warriorA.Attack();
        var warriorBBlockAmount = warriorB.Block();
        var blockPercentage = warriorBBlockAmount * 100 / warriorAAttackAmount;

        if (blockPercentage >= 90)
        {
            Console.WriteLine($"{warriorB.Name} Blocks {warriorA.Name} Attack");
            Console.WriteLine($"{warriorB.Name} Health: {warriorB.Health}\n");
            return "Fight Again";
        }

        var damage2WarriorB = warriorAAttackAmount - warriorBBlockAmount;

        if (damage2WarriorB > 0)
            warriorB.Health -= damage2WarriorB;
        else
            damage2WarriorB = 0;

        if (warriorB.Health < 0) warriorB.Health = 0;

        damage2WarriorB = Math.Round(damage2WarriorB, 2);
        warriorB.Health = Math.Round(warriorB.Health, 2);

        Console.WriteLine($"{warriorA.Name} Attacks {warriorB.Name} and Deals {damage2WarriorB} Damage");
        Console.WriteLine($"{warriorB.Name} Has {warriorB.Health} Health\n");
        Console.WriteLine();
        if (warriorB.Health <= 0)
        {
            Console.WriteLine($"{warriorB.Name} has Died \n");
            return "Game Over";
        }

        return "Fight Again";
    }
}