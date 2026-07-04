using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string Name = Console.ReadLine();

        Console.Write("Enter you last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {Name}, {Name} {lastName}.");
    }
}