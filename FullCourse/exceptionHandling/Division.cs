namespace FullCourse.exceptionHandling;

public class Division
{
    private static double Divide(double a, double b)
    {
        return b == 0 ? throw new ZeroDivision() : a / b;
    }

    public static void main()
    {
        try
        {
            Console.WriteLine("Type two numbers to divided: ");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Result of {0} / {1} is {2}", a, b, Divide(a, b));
        }
        catch (ZeroDivision e)
        {
            Console.WriteLine(e.Message);
        }
    }
}