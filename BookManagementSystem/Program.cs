using BookManagementSystem.Models;

BMS bms = new BMS();

while (true)
{
    Console.WriteLine("===================================");
    Console.WriteLine("Welcome to the Book Management System!");
    Console.WriteLine("1. Add a new book");
    Console.WriteLine("2. View all books");
    Console.WriteLine("3. Get book by ID");
    Console.WriteLine("4. Remove a book");
    Console.WriteLine("5. Exit");

    Console.WriteLine();
    Console.Write("Please select an option: ");
    string input = Console.ReadLine();

    Console.WriteLine();


    switch (input)
    {
        case "1":
            bms.AddBook();
            break;
        case "2":
            bms.GetBooks();
            break;
        case "3":
            bms.GetBookByID();
            break;
        case "4":
            bms.RemoveBookByID();
            break;
        case "5":
            Console.WriteLine("Exiting the program. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}