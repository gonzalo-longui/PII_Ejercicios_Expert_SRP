using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        //Lista de shelves
        public string Name { get;  }
        public List<Shelf> Shelves { get; }

        public Sector(string name)
        {
            this.Name = name;
            this.Shelves = new List<Shelf>();
            LibraryManager.AddToListOfSectors(this);
        }

        public void PutShelfInSector(Shelf shelf)
        {
            this.Shelves.Add(shelf);
        }
    }
}