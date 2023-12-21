using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter2.Listings;

/// <summary>
///     A dictionary exhaustively representing a function
/// </summary>
public static class Listing5
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Chapter2)}.{nameof(Listing5)}");

        var frenchFor = new Dictionary<bool, string> { [true] = "Vrai", [false] = "Faux" };
        var falseInFrench = frenchFor[false];

        falseInFrench.Print(nameof(falseInFrench));

        Console.WriteLine($"Finished {nameof(Chapter2)}.{nameof(Listing5)}\n");
    }
}