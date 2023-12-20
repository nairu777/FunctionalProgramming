using FunctionalProgramming.Helpers.Printing;

namespace FunctionalProgramming.Chapter1.Listings;

public class Listing1_8
{
    public static void Execute()
    {
        Console.WriteLine($"Executing {nameof(Listing1_8)}");

        var vat = Vat(
            new Address("de"),
            new Order(
                new Product("Bananas", 2, true),
                6));
        vat.Print(nameof(vat));

        Console.WriteLine($"Finished {nameof(Listing1_8)}\n");
    }

    private static decimal Vat(Address address, Order order) =>
        address switch {
            ("de") _ => DeVat(order),
            (var country) _ => Vat(RateByCountry(country), order)
        };

    private static decimal RateByCountry(string country) => country switch
    {
        "it" => 0.22m,
        "jp" => 0.08m,
        _ => throw new ArgumentException($"Missing rate for {country}")
    };

    private static decimal Vat(decimal rate, Order order) => order.NetPrice * rate;

    private static decimal DeVat(Order order) =>
        order.NetPrice * (order.Product.IsFood ? 0.08m : 0.2m);

    private record Address(string Country);

    private record Product(string Name, decimal Price, bool IsFood);

    private record Order(Product Product, int Quantity)
    {
        public decimal NetPrice => Product.Price * Quantity;
    }
}