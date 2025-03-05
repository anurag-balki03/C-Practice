using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Model
{
    class Book
    {
        public Book()
        {
            Console.WriteLine("Hello user");
        }
        public Book(string Title, string Author)
        {
            Console.WriteLine($"Book Title : {Title}, Author : {Author}");
        }
        public Book(string Title, string Author, string ISBN)
        {
            Console.WriteLine($"Book Title : {Title}, Author : {Author}, ISBN : {ISBN}");

        }
    }
}
