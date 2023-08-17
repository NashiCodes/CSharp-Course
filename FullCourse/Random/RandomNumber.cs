namespace FullCourse;

public class RandomNumber
{
    public static void Guess()
    {
        Random random = new();
        var secretNumber = random.Next(1, 11);
        int numberGuessed;

        Console.WriteLine("Random num: {0}", secretNumber);

        do
        {
            Console.Write("Guess a number between 1 and 10: ");
            numberGuessed = Convert.ToInt32(Console.ReadLine());
            if (numberGuessed > secretNumber)
                Console.WriteLine("Too high!");
            else if (numberGuessed < secretNumber)
                Console.WriteLine("Too low!");
            else
                Console.WriteLine("You guessed it!");
        } while (numberGuessed != secretNumber);
    }
}