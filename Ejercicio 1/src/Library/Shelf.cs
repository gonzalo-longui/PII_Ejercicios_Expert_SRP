using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelf
    {
        //lista de books
        public string Name {get;}
        public List<Book> Books {get;}
        public Shelf(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }
        public void ShelveBook(Book book)
        {   
            this.Books.Add(book);
        }
    }
}