namespace FullCourse.exceptionHandling;

public class ZeroDivision : Exception
{
    public ZeroDivision() : base("You can't divide by zero!!")
    {
    }
}