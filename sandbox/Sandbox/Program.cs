using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("\n\nWhat is your first name?: ");
        string first_name= Console.ReadLine();
        Console.Write("\nWhat is your last name?: ");
        string last_name= Console.ReadLine();

        Console.WriteLine($"\nYour name is {last_name}, {first_name} {last_name}.\n");
    }
}