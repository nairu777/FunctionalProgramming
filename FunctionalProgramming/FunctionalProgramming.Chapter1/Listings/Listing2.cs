using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Functional approach: WHERE and ORDERBY create new lists
/// </summary>
public static class Listing2
{
    public static readonly Func<int, bool> IsOdd = x => x % 2 == 1;
}