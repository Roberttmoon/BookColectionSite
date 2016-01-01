using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookColectionSite
{
    class Publisher
    {
        Guid id;
        string name;
        List<Book> publishedWorks;
        Publisher()
        {
            publishedWorks = new List<Book>();
        }
    }
}
