using FunctionalProgramming.Helpers.Printing;
using static System.Linq.Enumerable;
using static System.Console;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Mutating state from concurrent processes
/// </summary>
public class Listing1_4
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Listing1_4)}");

        var nums = Range(-10000, 20001).Reverse().ToArray();

        var task1 = () => nums.Sum().Print("task1");
        var task2 = () =>
        {
            Array.Sort(nums);
            nums.Sum().Print("task2");
        };
        var task3 = () => nums.OrderBy(x => x).Sum().Print("task3");

        Parallel.Invoke(task1, task2);
        Parallel.Invoke(task1, task3);

        Console.WriteLine($"Finished {nameof(Listing1_4)}\n");
    }
}