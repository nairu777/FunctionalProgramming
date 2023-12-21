using System.Collections;
using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter2.Listings;

/// <summary>
///     A lambda accessing a variable from the enclosing scope
/// </summary>
public static class Listing4
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Chapter2)}.{nameof(Listing4)}");

        var days = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
        var daysStartingWithS = DaysStartingWith("S");
        var daysStartingWithT = DaysStartingWith("T");

        daysStartingWithS.Print(nameof(daysStartingWithS));
        daysStartingWithT.Print(nameof(daysStartingWithT));

        Console.WriteLine($"Finished {nameof(Chapter2)}.{nameof(Listing4)}\n");
        return;

        IEnumerable<DayOfWeek> DaysStartingWith(string s) =>
            days.Where(d => d.ToString().StartsWith(s));
    }
}