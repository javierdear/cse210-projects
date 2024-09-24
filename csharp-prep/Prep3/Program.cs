using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        int magicNumber, guessNumber;
        Console.WriteLine("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is your guess? ");
        guessNumber = int.Parse(Console.ReadLine());
        */

       /* if(guessNumber < magicNumber){
            Console.WriteLine("Higuer");
        }
        else if(guessNumber > magicNumber){
            Console.WriteLine("Lower");
        }
        else{
            Console.WriteLine("You guessed it!");
        }
        */
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber =0;
        Console.WriteLine("What is your guess? ");
        guessNumber = int.Parse(Console.ReadLine());

        while(guessNumber != magicNumber)
        {
            if(guessNumber < magicNumber){
                Console.WriteLine("Higuer");
                Console.WriteLine("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            else{
                Console.WriteLine("Lower");
                Console.WriteLine("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("You guessed it!");


    }
}