﻿using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Book b1 = new Book("AD1337", "Java for All", "John Potter", 352);
            Book b2 = new Book("XS3220", "Gardening", "Alex Sohn", 220);
            Book b3 = new Book("DD0095", "Cars in the USA", "Susan Dreyer", 528);
            Book b4 = new Book("PT1295", "Copenhagen Dawn", "Dan Mygind", 104);
            Book b5 = new Book("PT1295", "Copenhagen Dawn", "Dan Mygind", 104);

            BookCatalog theCatalog = new BookCatalog();
            theCatalog.AddBook(b1);
            theCatalog.AddBook(b2);
            theCatalog.AddBook(b3);
            theCatalog.AddBook(b4);
            theCatalog.AddBook(b5);

            Console.WriteLine("------------- Printing all books ---------------");
            theCatalog.PrintAllBooks();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            SafePrintBookInformation(theCatalog.LookupBook("AD1337"));
            SafePrintBookInformation(theCatalog.LookupBook("AD1338"));
            SafePrintBookInformation(theCatalog.LookupBook("PT1295"));
            SafePrintBookInformation(theCatalog.LookupBook("......"));
            SafePrintBookInformation(theCatalog.LookupBook("ad1337"));



            // The LAST line of code should be ABOVE this line
        }

        public void SafePrintBookInformation(Book aBook)
        {
            if (aBook == null)
            {
                Console.WriteLine("Book was null...");
            }
            else
            {
                Console.WriteLine(aBook.GetAllInformation());
            }
        }
    }
}
