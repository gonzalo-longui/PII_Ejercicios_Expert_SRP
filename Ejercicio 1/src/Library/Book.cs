using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        /*
        Expert: el libro no tiene por qué saber en qué sector o shelf está.
        SRP: el libro no tiene la responsabilidad de saber esas cosas

        Se crean clases Sector y Shelf con sus respectivos métodos para efectos similares al anterior método ShelveBook
        Se crea LibraryManager, que tiene una lista estática de todos los sectores, y un método FindBookLocation para localizar un objeto Book
        en sector/shelf
        */
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
