using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine(); 
        Console.WriteLine(first); 

     Console.WriteLine("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine(last);  
        Console.WriteLine($"Yor name is {last}, {first}, {last}");       

        
        
    }
}