using System;

namespace ClassLibraryNET
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public int ISBN13 { get; set; }

        public Book()
        {
            
        }

        public Book(string title, string author, int pageNumber, int isbn13)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            ISBN13 = isbn13;
        }
    }


}
