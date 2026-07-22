using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }    

        public Book BindBook(Book book)
        {
            this.BookId = book.BookId;
            this.Title = book.Title;
            this.Author = book.Author;
            this.PublishedDate = book.PublishedDate;

            return this;
        }    
    }
}