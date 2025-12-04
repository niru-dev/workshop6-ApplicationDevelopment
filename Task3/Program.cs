using System;

class Program
{
    // Method that accepts an array and a condition
    static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int n in numbers)
        {
            if (condition(n))
            {
                Console.WriteLine(n);
            }
        }
    }

    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 12, 18, 7 };

        Console.WriteLine("Even numbers:");
        ProcessNumbers(nums, n => n % 2 == 0);

        Console.WriteLine("\nNumbers > 10:");
        ProcessNumbers(nums, n => n > 10);
    }
}