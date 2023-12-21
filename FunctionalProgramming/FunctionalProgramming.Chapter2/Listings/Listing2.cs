using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter2.Listings;

/// <summary>
///     Instantiating and using a delegate
/// </summary>
public static class Listing2
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Chapter2)}.{nameof(Listing2)}");

        var list = Enumerable.Range(1, 10)
            .Select(i => i * 3)
            .ToList();
        Comparison<int> alphabetically = (l, r) =>
            string.Compare(l.ToString(), r.ToString(), StringComparison.Ordinal);
        list.Sort(alphabetically);

        list.Print(nameof(list));

        Console.WriteLine($"Finished {nameof(Chapter2)}.{nameof(Listing2)}\n");
    }
}