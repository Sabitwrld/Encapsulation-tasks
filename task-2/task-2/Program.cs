namespace task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Kitab1", 15, "Fantastik");
            Book book2 = new Book(2, "Kitab2", 25, "Roman");
            Book book3 = new Book(3, "Kitab3", 10, "Qorxu");

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("ID ile axtaris:");
            Book foundBookById = library.GetBookById(1);
            if (foundBookById != null)
            {
                Console.WriteLine("Tapilan kitab: " + foundBookById.Name);
            }
            else
            {
                Console.WriteLine("Kitab tapilmadi.");
            }

            // Kitapları ad ilə axtarırıq
            Console.WriteLine("Ad ile axtaris:");
            Book foundBookByName = library.GetBookByName("Kitab2");
            if (foundBookByName != null)
            {
                Console.WriteLine("Tapilan kitab: " + foundBookByName.Name);
            }
            else
            {
                Console.WriteLine("Kitab tapilmadi.");
            }

            // Adla hissə-hissə axtarış edirik
            Console.WriteLine("Adla hisse-hisse axtaris:");
            Book[] booksByName = library.GetBooksByName("kit");
            if (booksByName.Length > 0)
            {
                foreach (var book in booksByName)
                {
                    Console.WriteLine("Tapilan kitab: " + book.Name);
                }
            }
            else
            {
                Console.WriteLine("Kitab tapilmadi.");
            }

            
            Console.WriteLine("Janra gore axtaris:");
            Book[] booksByGenre = library.GetFilteredBook("Roman");
            if (booksByGenre.Length > 0)
            {
                foreach (var book in booksByGenre)
                {
                    Console.WriteLine("Tapilan kitab: " + book.Name);
                }
            }
            else
            {
                Console.WriteLine("Kitab tapilmadi.");
            }

           
            Console.WriteLine("Qiymet araligina gore:");
            Book[] booksByPrice = library.GetFiltredBooks(10, 20);
            if (booksByPrice.Length > 0)
            {
                foreach (var book in booksByPrice)
                {
                    Console.WriteLine("Tapılan kitab: " + book.Name + " - " + book.Price + " AZN");
                }
            }
            else
            {
                Console.WriteLine("Kitab tapılmadı.");
            }


        }
    }
}
