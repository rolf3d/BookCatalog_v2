using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BookCatalog
    {
        private Dictionary<string,Book> books;

        public BookCatalog()
        {
            books = new Dictionary<string, Book>();
        }

        public void AddBook(Book aBook)
        {
            // Add code that can add the given Book object to the list
            books.Add(aBook.GetISBN(), aBook);
        }

        public void PrintAllBooks()
        {
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement
            foreach (KeyValuePair<string, Book> materiale in books)
            {
                Book enBog = materiale.Value;
                Console.WriteLine(enBog.GetAllInformation());
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            // Add code that will find a book (if any) in the list
            // which has a matching ISBN number. The variable matchingBook
            // should be set to this book
            // Hint: You can use isbn to lookup the book in the Dictionar

            if (books.ContainsKey(isbn))
            {
                Console.WriteLine("Vi fandt følgende bøger hjemme: ");
                return books[isbn];
                
            }
            else
            {
                Console.WriteLine("Vi fandt desværre ikke lige det du søgte ");
                
            }
            if (matchingBook == null)
            {
                Console.WriteLine("Der var desvæære ikke noget:");

            }
            return matchingBook;
        }
    }
}
