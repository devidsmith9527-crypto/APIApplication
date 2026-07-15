using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApplication.Models
{    
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;
        public DateTime DOB { get; set; } = DateTime.Now;
        public string Email { get; set; } = string.Empty;
        public string Telegram { get; set; } = string.Empty;
    }

}