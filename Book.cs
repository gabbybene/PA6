using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA6
{
    class Book
    {
        public String CWID { get; set; }
        public String isbn { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String cover { get; set; }
        public String genre { get; set; }
        public int length { get; set; }
        public int copies { get; set; }
        public String _id { get; set; }

        public Book(String CWID, String isbn, String title, String author, String cover, String genre, int length, int copies, String id)
        {
            this.CWID = CWID;
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.cover = cover;
            this.genre = genre;
            this.length = length;
            this.copies = copies;
            _id = id;
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
