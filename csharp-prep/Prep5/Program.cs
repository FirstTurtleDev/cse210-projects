using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int year;
        int num = SquareNumber(PromptUserNumber());
        PromptUserBirthYear(out year);
        DisplayResult(name, num, year);
    }
    static void DisplayWelcome()
    {
        Console.Write("Welcome to the Program!\n");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoritenum = int.Parse(Console.ReadLine());
        return favoritenum;
    }

    static void PromptUserBirthYear(out int x)
    {
        Console.Write("In what year was the user born? ");
        x = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int squarednum, int year)
    {
        Console.Write($"{name}, the square of your number is {squarednum}\n");
        Console.Write($"{name}, you will turn {2026 - year} this year");
    }
}