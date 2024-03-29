﻿using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Functional approach: WHERE and ORDERBY create new lists
/// </summary>
public static class Listing2
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Chapter1)}.{nameof(Listing2)}");

        var isOdd = (int x) => x % 2 == 1;
        var original = new[] { 7, 6, 1 };
        var sorted = original.OrderBy(x => x);
        var filtered = original.Where(isOdd);

        original.Print(nameof(original));
        sorted.Print(nameof(sorted));
        filtered.Print(nameof(filtered));

        Console.WriteLine($"Finished {nameof(Chapter1)}.{nameof(Listing2)}\n");
    }
}