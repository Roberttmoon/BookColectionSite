using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookColectionSite
{
    public class Book
    {
        Guid id;
        string title;
        List<string> author;


        public static Book NewBook(string newTitle, List<string> newAuthor)
        {
            Book newBook = new Book();
            newBook.id = new Guid();
            newBook.title = newTitle;
            newBook.author = newAuthor;
            return newBook;
        }
    }
}
