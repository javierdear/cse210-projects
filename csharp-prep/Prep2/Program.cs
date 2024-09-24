using System;

class Program
{
    static void Main(string[] args)
    {
        //A >= 90
        //B >= 80
        //C >= 70
        //D >= 60
        //F < 60
        string letter;
        Console.WriteLine("Please, enter your grade percentage: ");
        int percent = int.Parse(Console.ReadLine());

        if (percent >= 90){
            letter = "A";
        }
        else if (percent >= 80){
            letter = "B";
        }
        else if (percent >= 70){
            letter = "C";
        }
        else if (percent >= 60){
            letter = "D";
        }
        else{
            letter = "F";
        }
        Console.WriteLine("The grade letter is: " + letter);
        if (percent >= 70){
            Console.WriteLine("Congratulations!");
        }
        else{
            Console.WriteLine("Sorry, try again!");
        }
    }
}