namespace FunctionalProgramming.Helpers.Strings;

public static class Strings
{
    public static string CapitalizeFirstLetter(this string input) =>
        string.IsNullOrEmpty(input)
            ? string.Empty
            : input[..1].ToUpper() + input[1..];
}