using System;

public class Class2
{
    static void Main() 
    {
        Console.WriteLine("what is your first name? ");
        string? name = Console.ReadLine();
        Console.WriteLine("what is your last name? ");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Your name is " + name + " " + lastName);
    }
}