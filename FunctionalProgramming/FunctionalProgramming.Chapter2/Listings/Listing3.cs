using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter2.Listings;

/// <summary>
///     Declaring a function inline with a lambda
/// </summary>
public static class Listing3
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Chapter2)}.{nameof(Listing3)}");

        var list = Enumerable.Range(1, 10)
            .Select(i => i * 3)
            .ToList();
        list.Sort((l, r) =>
            string.Compare(l.ToString(), r.ToString(), StringComparison.Ordinal));

        list.Print(nameof(list));

        Console.WriteLine($"Finished {nameof(Chapter2)}.{nameof(Listing3)}\n");
    }
}