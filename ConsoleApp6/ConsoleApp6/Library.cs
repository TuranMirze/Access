using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Library
    {
        public Book[] Books;


        public Library()
        {
            Books = new Book[0];
        }


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }


        public void GetFilteredBooks(string genre)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Console.Write(Books[i].No + " ");
                    Console.Write(Books[i].Genre + " ");
                    Console.Write(Books[i].Name + " ");
                    Console.Write(Books[i].Price + " ");
                }
            }
        }


        public void GetFilteredBooks(double minPrice, double maxPrice)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (minPrice < Books[i].Price && maxPrice >= Books[i].Price)
                {
                    Console.Write(Books[i].No + " ");
                    Console.Write(Books[i].Genre + " ");
                    Console.Write(Books[i].Name + " ");
                    Console.Write(Books[i].Price + " ");
                    Console.WriteLine();
                }
            }

        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.Write(Books[i].No + " ");
                Console.Write(Books[i].Genre + " ");
                Console.Write(Books[i].Name + " ");
                Console.Write(Books[i].Price + " ");
                Console.WriteLine();
            }
        }
    }
}
