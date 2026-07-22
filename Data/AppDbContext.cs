using Microsoft.EntityFrameworkCore;
using APIApplication.Models;

namespace APIApplication.Data
{
    // ត្រូវតែស្នងត្រកូលពី class DbContext របស់ EF Core
    public class AppDbContext : DbContext
    {
        // Constructor សម្រាប់ទទួលយកការកំណត់ (Connection String) ពី Program.cs
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // ប្រកាស DbSet: Class 'Student' នឹងត្រូវបម្លែងជា Table ឈ្មោះ 'Students'
        public DbSet<Student> Students { get; set; }
    }
}