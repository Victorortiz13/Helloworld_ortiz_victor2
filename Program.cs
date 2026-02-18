namespace Helloworld_ortiz_victor2 //My collection of classes for this project.
{
    internal class Program // Main class for our program
    {
        static void Main(string[] args) // The main method is executed when application starts
        {
            Console.WriteLine("What is your first name?"); // Asks the user for first name
            string firstName = Console.ReadLine(); // Assaigns user input to firstname variable
            Console.WriteLine("What is your last name?"); // Asks the user for last name
            string lastName = Console.ReadLine(); // Assaigns user input to lastname variable
            Console.WriteLine($"Hello,{firstName} {lastName}!"); // Prints a welcome message with firstname and lastname
        }
    }
}
