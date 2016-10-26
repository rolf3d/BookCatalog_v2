using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BookCatalog
    {
        private Dictionary<string, Book> books;

        public BookCatalog()
        {
            books = new Dictionary<string, Book>();
        }

        public void AddBook(Book aBook)
        {
            // Add the given Book object to the Dictionary
            // ISBN is the Key for a Book object
            books.Add(aBook.GetISBN(), aBook);
        }

        public void PrintAllBooks()
        {
            // For all books in the Dictionary, print out information for each book
            foreach (KeyValuePair<string, Book> kvp in books)
            {
                Book b = kvp.Value;
                Console.WriteLine(b.GetAllInformation());
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            // See if a book with the given key (isbn) is in the Dictionary
            if (books.ContainsKey(isbn))
            {
                matchingBook = books[isbn]; // Now matchingBook refers to the book with the matching ISBN
            }

            return matchingBook;
        }
    }
}
