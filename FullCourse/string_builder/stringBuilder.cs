using System.Globalization;
using System.Text;

namespace FullCourse.string_builder;

public class stringBuilder
{
    public static void main()
    {
        StringBuilder sb = new StringBuilder("Random Text");
        StringBuilder sb2 = new StringBuilder("Stuff very important", 256);

        Console.WriteLine("Capacity: {0}", sb2.Capacity);
        Console.WriteLine("Length: {0}", sb2.Length);

        sb2.AppendLine("\nMore important text");

        CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
        string besCust = "Bob Smith";

        sb2.AppendFormat(enUS, "Best Customer: {0}", besCust);
        Console.WriteLine(sb2.ToString());

        sb2.Replace("text", "characters");
        Console.WriteLine(sb2.ToString());

        sb2.Clear();
        sb2.Append(sb.ToString());
        Console.WriteLine(sb2.ToString());

        Console.WriteLine(sb.Equals(sb2));
        sb2.Insert(11, " that's great");
        Console.WriteLine(sb2.ToString());

        sb2.Remove(11, 7);
        Console.WriteLine(sb2.ToString());

    }

}