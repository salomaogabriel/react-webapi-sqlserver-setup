using Microsoft.EntityFrameworkCore;

using simpleAPI.Models;
namespace simpleAPI.Data;

  public class SimpleContext : DbContext
    {
        // public DbSet<Address> Address { get; set; }
        // public DbSet<Customer> Customers { get; set; }

        // Create a Table:
        // public DbSet<Model> TableName { get; set; }
          public SimpleContext(DbContextOptions<SimpleContext> options)
      : base(options)
  {
  }
        public DbSet<Simple>? TableName { get; set; }
        
        
    }