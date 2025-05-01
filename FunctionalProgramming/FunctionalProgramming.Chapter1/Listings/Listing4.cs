using static System.Linq.Enumerable;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Mutating state from concurrent processes
/// </summary>
public static class Listing4
{
    public static void ExecuteTask1And2(int[] nums)
    {
        Parallel.Invoke(() => Task1(nums), () => Task2(nums));
    }

    public static void ExecuteTask1And3(int[] nums)
    {
        Parallel.Invoke(() => Task1(nums), () => Task3(nums));
    }

    private static Action<int[]> Task1 => nums => Console.WriteLine(nums.Sum());
    private static Action<int[]> Task2 => nums =>
    {
        Array.Sort(nums);
        Console.WriteLine(nums.Sum());
    };
    private static Action<int[]> Task3 => nums => Console.WriteLine(nums.OrderBy(x => x).Sum());
}