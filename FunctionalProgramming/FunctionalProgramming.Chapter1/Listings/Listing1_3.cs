using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Non-functional approach: List<T>.Sort sorts the list in place
/// </summary>
public class Listing1_3
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Listing1_3)}");

        int[] original = { 5, 7, 1 };
        Array.Sort(original);

        original.Print(nameof(original));

        Console.WriteLine($"Finished {nameof(Listing1_3)}\n");
    }
}