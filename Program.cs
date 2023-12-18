using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography;

namespace deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            string Playerinput;
            string flipResult;
            int score = 0;


            Console.WriteLine("Welcome to the Coin Flip Challenge");

            Console.WriteLine("What is your name?");

            string PlayerName = Console.ReadLine();

            Console.WriteLine($"Welcome {PlayerName}. Do you want to play the coin flip challenge? Yes/No."); 
            
            string PlayerAnswer = Console.ReadLine();

            if (PlayerAnswer == "No")
            {
                Console.WriteLine("You are a coward," + PlayerName);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Random coinflip = new Random();
                    int coin = coinflip.Next(0, 2);
                    Console.WriteLine("Choose 'heads' or 'tails'");
                    Playerinput = Console.ReadLine();
                    if (coin == 0)
                    {
                        flipResult = "Heads";
                    }
                    else
                    {
                        flipResult = "Tails";
                    }
                    if ((flipResult == "Heads" && Playerinput == "heads") || (flipResult == "Tails" && Playerinput == "tails"))
                    {
                        Console.WriteLine($"You guessed correctly, {PlayerName}!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"You guessed incorrectly, {PlayerName}!");
                    }
                }
                Console.WriteLine($"Your score is {score}. Thanks for playing {PlayerName}");
            }  
        } 
    }
}