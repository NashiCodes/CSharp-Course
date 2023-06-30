namespace FullCourse.exceptions;

public class ZeroDivision : Exception
{
    public ZeroDivision() : base("You can't divide by zero!!")
    {
    }
}