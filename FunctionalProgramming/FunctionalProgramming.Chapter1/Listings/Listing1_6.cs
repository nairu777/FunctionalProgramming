using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Positional records
/// </summary>
public class Listing1_6
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Listing1_6)}");

        var testProduct = new Product("Bananas", 2, true);
        var testOrder = new Order(testProduct, 6);
        testOrder.Print(nameof(testOrder));

        Console.WriteLine($"Finished {nameof(Listing1_6)}\n");
    }

    private record Product(string Name, decimal Price, bool IsFood);

    private record Order(Product Product, int Quantity)
    {
        public decimal NetPrice => Product.Price * Quantity;
    }
}