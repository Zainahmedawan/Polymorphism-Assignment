// Employee class inherits from IQuittable interface
public class Employee : IQuittable
{
    // Property to store employee ID
    public int Id { get; set; }

    // Property to store employee first name
    public string FirstName { get; set; }

    // Property to store employee last name
    public string LastName { get; set; }

    // Implementation of the Quit method required by IQuittable
    public void Quit()
    {
        // Displays a message when the employee quits
        Console.WriteLine($"{FirstName} {LastName} has quit the company.");
    }
}
