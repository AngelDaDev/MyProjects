using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Parada_Test_3
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string IsAvailable { get; set; }

        public Book(string title, string author, string isbn, string available)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = available;
        }
        public string GetBook()
        {
            return $"{this.Title}, {this.Author}, {this.ISBN}, {this.IsAvailable}";
        }
    }
}
