using System;

delegate int Calculate(int a, int b);
delegate double DiscountStrategy(double price);

class Program
{
    // Methods for Calculate delegate
    static int Add(int x, int y) => x + y;
    static int Subtract(int x, int y) => x - y;

    // Discount methods
    static double FestivalDiscount(double price) => price * 0.80; // 20% off
    static double SeasonalDiscount(double price) => price * 0.90; // 10% off
    static double NoDiscount(double price) => price;        // no change

    // method that uses DiscountStrategy delegate
    static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        => strategy(originalPrice);

    static void Main()
    {
        Calculate calc;

        calc = Add;
        Console.WriteLine($"Add(10, 5) = {calc(10, 5)}");

        calc = Subtract;
        Console.WriteLine($"Subtract(10, 5) = {calc(10, 5)}");

        // Discount delegate examples
        double originalPrice = 1000;

        Console.WriteLine("\n--- Using discount methods ---");
        Console.WriteLine($"Festival discount:  {FestivalDiscount(originalPrice)}");
        Console.WriteLine($"Seasonal discount:  {SeasonalDiscount(originalPrice)}");
        Console.WriteLine($"No discount:        {NoDiscount(originalPrice)}");

        Console.WriteLine("\n--- Using CalculateFinalPrice() ---");

        Console.WriteLine("Festival:  " +
            CalculateFinalPrice(originalPrice, FestivalDiscount));

        Console.WriteLine("Seasonal:  " +
            CalculateFinalPrice(originalPrice, SeasonalDiscount));

        Console.WriteLine("No disc.: " +
            CalculateFinalPrice(originalPrice, NoDiscount));

        // use a lambda expression for 30% discount
        Console.WriteLine("\n--- 30% Lambda discount ---");
        double finalWithLambda = CalculateFinalPrice(
            originalPrice,
            price => price * 0.70
        );
        Console.WriteLine($"30% off: {finalWithLambda}");
    }
}