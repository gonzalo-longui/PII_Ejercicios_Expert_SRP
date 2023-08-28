using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelf shelf1 = new Shelf("0");
            Shelf shelf2 = new Shelf("1");
            shelf1.ShelveBook(book1);
            shelf2.ShelveBook(book2);
            Sector sector1 = new Sector("A");
            Sector sector2 = new Sector("B");
            sector1.PutShelfInSector(shelf1);
            sector2.PutShelfInSector(shelf2);
            LibraryManager.FindBookLocation(book1);
        }
    }
}