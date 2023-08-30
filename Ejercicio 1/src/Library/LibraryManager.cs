using System;
using System.Collections.Generic;

namespace SRP
{
    public class LibraryManager
    {

        //Lista estática master con todos los sectors
        /*
            ClassName: LibraryManager
            Responsabilidades: 
             - conocer todos los sectores
             - agregar sector a lista de sectores
             - saber dónde estan todos los libros dentro de los sectores / shelves
            Colaboradores: 
             - Sector
             - Shelf
             - Book
        */
        private static List<Sector> sectors = new List<Sector>();
        
        public static void AddToListOfSectors(Sector sector)
        {
            sectors.Add(sector);
        }
        //método para encontrar un libro. busca en cada sector, shelf y book
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