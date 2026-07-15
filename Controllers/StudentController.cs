using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using APIApplication.Models;

namespace APIApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // URL Base: api/student
    public class StudentController : ControllerBase
    {
        // បញ្ជីសិស្សសិប្បនិម្មិតក្នុង memory
        private static List<Student> _students = new()
        {
            new Student { Id = 1, Name = "Dara SOK", Major = "Computer Science" },
            new Student { Id = 2, Name = "Cheata SENG", Major = "Information Technology" },
            new Student { Id = 3, Name = "Sopheap CHHAY", Major = "Software Engineering" },
            new Student { Id = 4, Name = "Rithy KIM", Major = "Data Science" },
            new Student { Id = 5, Name = "Sreyneang HENG", Major = "Cybersecurity" }
        };

        // ១. GET: api/student (ទាញយកសិស្សទាំងអស់)
        [HttpGet]
        public IActionResult GetAll() => Ok(_students);

        // ២. GET: api/student/1 (ទាញយកតាម ID)
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = _students.Find(X => X.Id == id);
            if (student == null) 
                return NotFound($"រកមិនឃើញសិស្សដែលមាន ID = {id}");
            return Ok(student);
        }
    }
}