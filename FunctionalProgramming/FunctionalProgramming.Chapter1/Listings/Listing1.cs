namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     A simple example of using a function as a first-class value
/// </summary>
public static class Listing1
{
    public static readonly Func<int, int> Triple = x => x * 3;
}