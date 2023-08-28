using System;
using System.Collections.Generic;

namespace SRP
{
    public class LibraryManager
    {
        public static List<Sector> sectors = new List<Sector>();
        
        public static void FindBookLocation(Book book)
        {
            foreach (Sector sector in sectors)
            {
                foreach (Shelf shelf in sector.Shelves)
                {
                    foreach (Book bookInShelf in shelf.Books)
                    {
                        if (bookInShelf == book)
                        {
                            Console.WriteLine($"Book \"{book.Title}\" is on shelf {shelf.Name} in sector {sector.Name}.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"Book \"{book.Title}\" was not found.");
        }
    }
}