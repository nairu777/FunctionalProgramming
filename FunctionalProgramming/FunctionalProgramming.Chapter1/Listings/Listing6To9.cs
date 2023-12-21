using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Patten matching and record types
/// </summary>
public class Listing6To9
{
    /// <summary>
    ///     Positional records
    /// </summary>
    public static void ExecuteListing6()
    {
        Console.WriteLine($"Executing {nameof(Chapter1)}.Listing6");

        var testProduct = new Product("Bananas", 2, true);
        var testOrder = new Order(testProduct, 6);
        testOrder.Print(nameof(testOrder));

        Console.WriteLine($"Finished {nameof(Chapter1)}.Listing6\n");
    }

    /// <summary>
    ///     Pattern matching on a value
    /// </summary>
    public static void ExecuteListing7()
    {
        Console.WriteLine($"Executing {nameof(Chapter1)}.Listing7");

        var testProduct = new Product("Bananas", 2, true);
        var testOrder = new Order(testProduct, 6);
        var testAddress = new Address("it");

        var vat = Vat(testAddress, testOrder);
        vat.Print(nameof(vat));

        Console.WriteLine($"Finished {nameof(Chapter1)}.Listing7\n");
    }

    /// <summary>
    ///     Deconstructing a record in a poattern matching expression
    /// </summary>
    public static void ExecuteListing8()
    {
        Console.WriteLine($"Executing {nameof(Chapter1)}.Listing8");

        var testAddress = new Address("de");
        var testOrder = new Order(new Product("Bananas", 2, true),6);
        var vat = Vat(testAddress, testOrder);
        vat.Print(nameof(vat));

        Console.WriteLine($"Finished {nameof(Chapter1)}.Listing8\n");
    }

    /// <summary>
    ///     Pattern matching by type
    /// </summary>
    public static void ExecuteLisitng9()
    {
        Console.WriteLine($"Executing {nameof(Chapter1)}.Listing9");

        var testAddress = new UsAddress("ny");
        var testOrder = new Order(new Product("Bananas", 2, true),6);
        var vat = Vat(testAddress, testOrder);
        vat.Print(nameof(vat));

        Console.WriteLine($"Finished {nameof(Chapter1)}.Listing9\n");
    }

    private static decimal Vat(Address address, Order order) =>
        address switch {
            UsAddress(var state) => Vat(RateByState(state), order),
            ("de") _ => DeVat(order),
            (var country) _ => Vat(RateByCountry(country), order)
        };

    private static decimal RateByCountry(string country) => country switch
    {
        "it" => 0.22m,
        "jp" => 0.08m,
        _ => throw new ArgumentException($"Missing rate for {country}")
    };

    private static decimal RateByState(string state) => state switch
    {
        "ca" => 0.1m,
        "ma" => 0.0625m,
        "ny" => 0.085m,
        _ => throw new ArgumentException($"Missing rate for state {state}")
    };

    private static decimal Vat(decimal rate, Order order) => order.NetPrice * rate;

    private static decimal DeVat(Order order) =>
        order.NetPrice * (order.Product.IsFood ? 0.08m : 0.2m);

    private record Address(string Country);

    private record UsAddress(string State) : Address("us");

    private record Product(string Name, decimal Price, bool IsFood);

    private record Order(Product Product, int Quantity)
    {
        public decimal NetPrice => Product.Price * Quantity;
    }
}