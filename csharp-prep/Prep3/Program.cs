using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        Console.WriteLine("Welcome to the Magic Number Game!");

        // Ask the player to set the magic number
        int magicNumber;
        while(true)
        {
            Console.Write("Player 1, please enter the magic number (1-100:) ");
            string input = 
            Console.ReadLine();

            if
            (int.TryParse(input, out magicNumber)
            && magicNumber >= 1 && magicNumber <=100)
            {
                Console.Clear();  //clear the console to hide the magic number
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
              }

              int attempts = 0;
              Console.WriteLine("Player 2, its your turn to guess the magic number!");

              // Player 2 guesses the number
              while (true)
              {
                Console.Write("Enter the guess: ");
                string  guessInput = Console.ReadLine();
                attempts++;
                if 
                (int.TryParse(guessInput, out int guess))
                {
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess >magicNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed it!");
                        break;
                    }
                }  
              }
=======
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        

        while (guess != magicNumber)
         {
            
            guess = int.Parse(Console.ReadLine());

        }
       if (magicNumber > guess)
        { 
        Console.WriteLine("Higher");

        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
    
        else 
        {
            Console.WriteLine("You guessed it");
            
        }

>>>>>>> 95adb64fddf21578bb2bbefe8634f820e8fbc3f2
    }
}