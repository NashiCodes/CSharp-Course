namespace FullCourse.enum_ex;

public class ExEnum
{
    private static void PaintCar(CarColor cc)
    {
        Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
    }

    public static void main()
    {
        var car1 = CarColor.Blue;
        PaintCar(car1);
        Console.WriteLine("\n===================================================\n");

        var meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
        Console.WriteLine("Meeting days are: {0}", meetingDays);

        Console.WriteLine("\n===================================================\n");

        var HomeOfficeDays = Days.Workday & ~meetingDays;
        Console.WriteLine("Home office days are: {0}", HomeOfficeDays);
        //output:
        //Home office days are: Tuesday, Thursday

        Console.WriteLine("\n===================================================\n");

        var isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
        Console.WriteLine("Is there a meeting on Tuesday: {0}", isMeetingOnTuesday);

        Console.WriteLine("\n===================================================\n");

        var OffDays = Days.Weekend | Days.Monday;
        Console.WriteLine("Off days are: {0}", OffDays);

        Console.WriteLine("\n===================================================\n");

        Console.WriteLine("(Days)37: {0}", (Days)37);
    }

    [Flags]
    private enum Days
    {
        None = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
        Weekend = Saturday | Sunday,
        Workday = Monday | Tuesday | Wednesday | Thursday | Friday
    }

    private enum CarColor : byte
    {
        Orange = 1,
        Blue,
        Green,
        Red,
        Yellow,
        Black,
        White
    }
}