using Microsoft.EntityFrameworkCore;
using MyApiProject.Models;

namespace MyApiProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        // public DbSet<Employee> Employees { get; set; } // already exists
    }
}
