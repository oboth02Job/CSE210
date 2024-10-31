using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string letter = "";

        //Determine the letter grade
        if (percent >= 90)
        {
         letter = "A";

        }
        else if (percent >= 80)
        {
            letter = "B";
            
        }
        else if (percent >= 70) 
        {
            letter = "C";
            
            
        }
        else if (percent >= 60)
        {
            letter = "D";
            
            }

            else
            {
                letter = "F";
             
             }  

             //print the letter grade
             Console.WriteLine($"Your grade is: {letter}");
        //Check if the user passed the course
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else 
        {
            Console.WriteLine("Keep trying and don't lose hope!");
        }

    }
}