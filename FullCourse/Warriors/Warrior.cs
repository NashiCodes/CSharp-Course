namespace FullCourse.Warriors;

internal class Warrior
{
    private readonly Random rnd = new();

    public Warrior(string name = "No Name", double health = 0, double attackMax = 0, double blockMax = 0)
    {
        Name = name;
        Health = health;
        AttackMax = attackMax;
        BlockMax = blockMax;
        maxHealth = health;
    }

    public string? Name { get; set; }
    public double Health { get; set; }
    public double maxHealth { get; set; }
    public double AttackMax { get; set; }
    public double BlockMax { get; set; }

    public double Attack()
    {
        return rnd.NextDouble() * AttackMax;
    }

    public virtual double Block()
    {
        return rnd.NextDouble() * BlockMax;
    }

    public void heal()
    {
        Health = maxHealth;
    }
}