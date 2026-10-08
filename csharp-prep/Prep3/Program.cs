using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNum = int.Parse(Console.ReadLine());
        int guess;

        do{
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNum){
                Console.Write("Lower!\n");
            }
            else if(guess < magicNum){
                Console.Write("Higher!\n");
            }
            else{
                Console.Write("You guessed it!");
            }
        } while(guess != magicNum);
    }
}