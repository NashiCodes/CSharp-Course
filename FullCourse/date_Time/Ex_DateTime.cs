using System.Globalization;

namespace FullCourse.date_Time;

public class ExDateTime
{
    public static void main()
    {
        var birthday = new DateTime(2002, 10, 22);
        Console.WriteLine(birthday.ToString(CultureInfo.CurrentCulture));
        Console.WriteLine(birthday.DayOfWeek);

        var date = new DateTime(birthday.Year, birthday.Month, birthday.Day);
        date = date.AddDays(10);
        Console.WriteLine(date.ToString(CultureInfo.CurrentCulture));

        var lunchTime = new TimeSpan(12, 30, 0);
        Console.WriteLine("Lunch time: {0}", lunchTime.ToString());

        lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
        Console.WriteLine("New lunch time: {0}", lunchTime.ToString());
    }
}