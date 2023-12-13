using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

/// <summary>
///     Pattern matching on a value
/// </summary>
public class Listing1_7
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Listing1_7)}");

        var testProduct = new Product("Bananas", 2, true);
        var testOrder = new Order(testProduct, 6);
        var testAddress = new Address("it");

        var vat = Vat(testAddress, testOrder);
        vat.Print(nameof(vat));

        Console.WriteLine($"Finished {nameof(Listing1_7)}\n");
    }

    private static decimal Vat(Address address, Order order) => Vat(RateByCountry(address.Country), order);

    private static decimal RateByCountry(string country) => country switch
    {
        "it" => 0.22m,
        "jp" => 0.08m,
        _ => throw new ArgumentException($"Missing rate for {country}")
    };

    private static decimal Vat(decimal rate, Order order) => order.NetPrice * rate;

    private record Address(string Country);

    private record Product(string Name, decimal Price, bool IsFood);

    private record Order(Product Product, int Quantity)
    {
        public decimal NetPrice => Product.Price * Quantity;
    }
}