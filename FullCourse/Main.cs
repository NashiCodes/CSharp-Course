using FullCourse.exceptions;

namespace FullCourse;

internal class MainClass
{
    private static double Divide(double a, double b)
    {
        return b == 0 ? throw new ZeroDivision() : a / b;
    }

    private static void Main()
    {
        RandomNumber.Guess();
        try
        {
            Console.WriteLine("Type two numbers to divided: ");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} / {1} = {2}", a, b, Divide(a, b));
        }
        catch (ZeroDivision)
        {
            Console.WriteLine("You can't divide by zero!!");
        }
    }
}