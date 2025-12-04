using System;
using System.Collections.Generic;
using System.Linq;

class TourBooking
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDays { get; set; }
    public bool IsInternational { get; set; }
}

class TourSummary
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public string Category { get; set; } // International / Domestic
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<TourBooking> bookings = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Roshna",  Destination = "ABC",  Price = 8000,  DurationInDays = 3, IsInternational = false },
            new TourBooking { CustomerName = "Samira", Destination = "Rara",  Price = 15000, DurationInDays = 5, IsInternational = true  },
            new TourBooking { CustomerName = "parash", Destination = "Tilicho",  Price = 12000, DurationInDays = 4, IsInternational = false },
            new TourBooking { CustomerName = "Roshni",Destination="Pathivara",    Price = 25000, DurationInDays = 6, IsInternational = true  }
        };

        // 1. Filter: price > 10,000 AND duration > 4 days
        var filtered = bookings
            .Where(b => b.Price > 10000 && b.DurationInDays > 4);

        // 2. Transform (project) into new list with Category
        var summaries = filtered
            .Select(b => new TourSummary
            {
                CustomerName = b.CustomerName,
                Destination = b.Destination,
                Price = b.Price,
                Category = b.IsInternational ? "International" : "Domestic"
            });

        // 3. Sort: Domestic first, then International; then by price
        var sorted = summaries
            .OrderBy(s => s.Category) // "Domestic" < "International" alphabetically
            .ThenBy(s => s.Price);

        // 4. Display clean output
        Console.WriteLine("Tour Summary Report:\n");
        foreach (var s in sorted)
        {
            Console.WriteLine(
                $"Customer: {s.CustomerName} | " +
                $"Destination: {s.Destination} | " +
                $"Category: {s.Category} | " +
                $"Price: Rs. {s.Price}");
        }
    }
}