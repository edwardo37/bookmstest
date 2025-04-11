namespace BookManagementSystem.Models
{
    public class BMS
    {
        // This is a dictionary because lookups are easier with IDs.
        private Dictionary<int, Book> Books { get; set; }

        public BMS()
        {
            // Initialize the dictionary
            Books = new Dictionary<int, Book>
            // REMOVE WHEN FINISHED, FOR TESTING PURPOSES
            {
                {1, new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", ID = 1 } },
                {2, new Book { Title = "TLOTR", Author = "F. Scott Fitzgerald", Genre = "Fiction", ID = 2 } },
                {3, new Book { Title = "1984", Author = "F. Scott Fitzgerald", Genre = "Fiction", ID = 3 } },
            };
        }

        public void AddBook()
        {
            Book newBook = new Book();

            // Enter in all the data
            Console.Write("Enter the title of the book: ");
            newBook.Title = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            newBook.Author = Console.ReadLine();

            Console.Write("Enter the genre of the book: ");
            newBook.Genre = Console.ReadLine();

            // Continue until a unique ID is entered
            while (true)
            {
                Console.Write("Enter the ID of the book: ");
                int proposedID = int.Parse(Console.ReadLine());

                // Check if the ID already exists
                if (Books.ContainsKey(proposedID))
                {
                    Console.WriteLine("This ID already exists. Please enter a unique ID.");
                    continue;
                }

                // ID is unique, so we can add the book
                else
                {
                    newBook.ID = proposedID;
                    Books.Add(proposedID, newBook);
                    break;
                }
            }
        }

        public void GetBooks()
        {
            foreach (Book book in Books.Values)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"ID: {book.ID}");
                Console.WriteLine("===================================");
            }
        }

        public void GetBookByID()
        {
            Console.Write("Enter the ID of the book to search for: ");
            int id = int.Parse(Console.ReadLine());

            if (Books.ContainsKey(id))
            {
                Book book = Books[id];

                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"ID: {book.ID}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void RemoveBookByID()
        {
            Console.Write("Enter the ID of the book to remove: ");
            int id = int.Parse(Console.ReadLine());

            if (Books.ContainsKey(id))
            {
                Book book = Books[id];

                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");

                // Confirm deletion
                Console.Write("Are you SURE you want to remove this book? (y/n): ");
                string confirmation = Console.ReadLine().ToLower();

                if (confirmation == "y")
                {
                    Books.Remove(id);
                    Console.WriteLine("Book removed successfully.");
                }
                else
                {
                    Console.WriteLine("Book removal cancelled.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}