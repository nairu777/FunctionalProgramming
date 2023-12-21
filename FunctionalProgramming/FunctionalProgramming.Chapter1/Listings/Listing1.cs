using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     A simple example of using a function as a first-class value
/// </summary>
public static class Listing1
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Chapter1)}.{nameof(Listing1)}");

        var triple = (int x) => x * 3;
        var range = Enumerable.Range(1, 3);
        var triples = range.Select(triple);

        triples.Print(nameof(triples));

        Console.WriteLine($"Finished {nameof(Chapter1)}.{nameof(Listing1)}\n");
    }
}