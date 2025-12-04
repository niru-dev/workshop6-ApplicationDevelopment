using System;
using System.Collections.Generic;
using System.Linq;

class CashierSales
{
    public string CashierName { get; set; }
    public decimal SalesAmount { get; set; }
}

class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Song
{
    public string Title { get; set; }
    public int DurationSeconds { get; set; }
}

class Program
{
    static void Main()
    {
        // Aggregation Operators
        List<CashierSales> sales = new List<CashierSales>
        {
            new CashierSales { CashierName = "Raymon", SalesAmount = 5000m },
            new CashierSales { CashierName = "parash", SalesAmount = 7000m },
            new CashierSales { CashierName = "Roshna", SalesAmount = 6500m }
        };

        int totalCashiers = sales.Count();
        decimal totalSales = sales.Sum(c => c.SalesAmount);
        decimal highest = sales.Max(c => c.SalesAmount);
        decimal lowest = sales.Min(c => c.SalesAmount);
        decimal average = sales.Average(c => c.SalesAmount);

        Console.WriteLine("Aggregation:");
        Console.WriteLine("Total cashiers: " + totalCashiers);
        Console.WriteLine("Total sales: " + totalSales);
        Console.WriteLine("Highest sale: " + highest);
        Console.WriteLine("Lowest sale: " + lowest);
        Console.WriteLine("Average sale: " + average);

        // Quantifier Operators
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "A", Age = 17 },
            new Applicant { Name = "B", Age = 18 },
            new Applicant { Name = "C", Age = 20 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("\nQuantifier Operators:");
        Console.WriteLine("Any applicant under 18? " + anyUnder18);
        Console.WriteLine("All applicants above 16? " + allAbove16);

        // Element Operators
        List<Song> songs = new List<Song>
        {
            new Song { Title = "Song 1", DurationSeconds = 180 },
            new Song { Title = "Song 2", DurationSeconds = 250 },
            new Song { Title = "Song 3", DurationSeconds = 420 }
        };

        Song firstSong = songs.First();
        Song lastSong = songs.Last();
        Song firstAbove4Min = songs.First(s => s.DurationSeconds > 240);
        Song firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

        Console.WriteLine("\nElement Operators:");
        Console.WriteLine("First song: " + firstSong.Title);
        Console.WriteLine("Last song: " + lastSong.Title);
        Console.WriteLine("First song longer than 4 min: " + firstAbove4Min.Title);
        if (firstAbove10Min == null)
            Console.WriteLine("No song longer than 10 minutes (safe result).");
        else
            Console.WriteLine("First song longer than 10 min: " + firstAbove10Min.Title);
    }
}