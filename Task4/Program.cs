using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
}

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // ---- Selecting / Projection ----
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squared = numbers.Select(n => n * n).ToList();

        Console.WriteLine("Squared numbers:");
        foreach (var n in squared)
            Console.WriteLine(n);

        // ---- Filtering (Where) ----
        List<Book> books = new List<Book>
        {
            new Book { Title = "Book A", Price = 800  },
            new Book { Title = "Book B", Price = 1200 },
            new Book { Title = "Book C", Price = 1500 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("\nBooks priced above Rs. 1000:");
        foreach (var b in premiumBooks)
            Console.WriteLine($"{b.Title} - {b.Price}");

        // ---- Sorting (OrderBy) ----
        List<Student> students = new List<Student>
        {
            new Student { Name = "Aarya" },
            new Student { Name = "Kanchan" },
            new Student { Name = "Sabina" },
            new Student { Name = "Anjali" }
        };

        var sortedStudents = students.OrderBy(s => s.Name);

        Console.WriteLine("\nStudents (sorted alphabetically):");
        foreach (var s in sortedStudents)
            Console.WriteLine(s.Name);
    }
}