using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Non-functional approach: List<T>.Sort sorts the list in place
/// </summary>
public static class Listing3
{
    public static void Sort(this int[] original) => Array.Sort(original);
}