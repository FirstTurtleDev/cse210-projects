using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>();
        int num = 1;
        Console.Write("Enter a list of numbers, type 0 when finished.");
        while (num != 0)
        {
            Console.Write("\nEnter number: ");
            num = int.Parse(Console.ReadLine());
            myList.Add(num);
        }
        Console.Write($"The sum is: {myList.Sum()}\n");
        Console.Write($"The average is: {myList.Average()}\n");
        Console.Write($"Thelargest number is: {myList.Max()}\n");
    }
}