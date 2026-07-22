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

        public Book BindBook(int bookId, string title, string author, DateTime publishedDate)
        {
            this.BookId = bookId;
            this.Title = title;
            this.Author = author;
            this.PublishedDate = publishedDate;
            return this;
        }          
    }
}