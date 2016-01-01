using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookColectionSite
{
    class Author : Person
    {
        List<string> penNames;
        List<Book> books;
        List<Publisher> publishers;

        Author()
        {
            penNames = new List<string>();
            books = new List<Book>();
            publishers = new List<Publisher>();

        }
        public static Author NewAuthor(string authorName, List<string> authorsPenNames, List<Book> authorsBooks)
        {
            Author newAuthor = new Author( );
            newAuthor.id = new Guid();
            newAuthor.name = authorName;
            newAuthor.penNames = authorsPenNames;
            newAuthor.books = authorsBooks;
            return newAuthor;
        }

    }
}

