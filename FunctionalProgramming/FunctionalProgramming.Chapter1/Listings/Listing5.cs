using FunctionalProgramming.Helpers.Printing;
using static System.Math;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     C# idioms relevant to FP
/// </summary>
public static class Listing5
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Chapter1)}.{nameof(Listing5)}");

        var circle = new Circle(3);

        circle.Print(nameof(circle));

        Console.WriteLine($"Finished {nameof(Chapter1)}.{nameof(Listing5)}\n");
    }

    private record Circle(double Radius)
    {
        public double Circumference => PI * 2 * Radius;

        public double Area
        {
            get
            {
                double Square(double d) => Pow(d, 2);
                return PI * Square(Radius);
            }
        }
    }
}