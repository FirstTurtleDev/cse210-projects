using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the students grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        bool pass = grade >= 70;
        string letter = CalculateGrade(grade);
        Console.Write($"The students grade letter is {letter} \n");
        Console.Write($"The student has {(pass ? "Passed" : "Failed")} the class!");
        
    }

    public static string CalculateGrade(int studentGrade)
    {
        bool pass = studentGrade >= 70;
        (string letter, int grade)[] grades =
        {
            ("A" , 90),
            ("B", 80),
            ("C", 70),
            ("D", 60),
            ("F", 0)
        };

        foreach (var letters in grades)
        {
            if (studentGrade >= letters.grade)
            {
                return letters.letter;
            }
        }

        return "F";
    }
}