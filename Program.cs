using System;

// Main program class
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Uses polymorphism by creating an Employee object
        // and storing it as an IQuittable type
        IQuittable employee = new Employee()
        {
            // Assigns values to Employee properties
            Id = 1,
            FirstName = "John",
            LastName = "Smith"
        };

        // Calls the Quit method through the interface reference
        employee.Quit();

        // Keeps the console window open until a key is pressed
        Console.ReadKey();
    }
}
