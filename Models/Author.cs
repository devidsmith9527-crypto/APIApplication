using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set;}
        public string AuthorEmail { get; set;}
        public DateTime? CreatedDate { get; set;}
    }
}