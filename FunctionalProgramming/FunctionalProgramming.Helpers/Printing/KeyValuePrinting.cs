using FunctionalProgramming.Helpers.Strings;

namespace FunctionalProgramming.Helpers.Printing;

public static class KeyValuePrinting
{
    public static void Print<T>(this IEnumerable<T> value, string key)
    {
        Console.WriteLine($"{key.CapitalizeFirstLetter()} : {string.Join(", ", value.ToArray())}");
    }

    public static void Print<T>(this IOrderedEnumerable<T> value, string key)
    {
        Console.WriteLine($"{key.CapitalizeFirstLetter()} : {string.Join(", ", value.ToArray())}");
    }

    public static void Print<T>(this List<T> value, string key)
    {
        Console.WriteLine($"{key.CapitalizeFirstLetter()} : {string.Join(", ", value.ToArray())}");
    }

    public static void Print<T>(this T[] value, string key)
    {
        Console.WriteLine($"{key.CapitalizeFirstLetter()} : {string.Join(", ", value.ToArray())}");
    }

    public static void Print<T>(this T value, string key)
    {
        Console.WriteLine($"{key.CapitalizeFirstLetter()} : {value}");
    }
}