namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();



            Book book1 = new Book(1, "Baskervillerin iti", 7, "Dedectiv");
            Book book2 = new Book(2, "Kapitan Qrantin usaqlari", 4, "Macera");
            Book book3 = new Book(3, "Mavi qatarin sirri", 6, "Dedectiv");
            Book book4 = new Book(4, "Beyaz dis", 7, "Roman");



            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Console.WriteLine("All Books:");
            library.ShowAllBooks();

            Console.WriteLine("Enter genre:");
            string genre = Console.ReadLine();
            Console.WriteLine(genre + " Kitablari:");
            library.GetFilteredBooks(genre);

            Console.WriteLine();
            Console.WriteLine("Enter the minimum:");
            int minprice;
            bool bool_minprice = int.TryParse(Console.ReadLine(), out minprice);

            Console.WriteLine("Enter the maximum:");

            int maxprice;
            bool bool_maxprice = int.TryParse(Console.ReadLine(), out maxprice);

            library.GetFilteredBooks(minprice, maxprice);
        }
    }
}



