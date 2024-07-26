namespace Said_Project.Connection;
using Microsoft.EntityFrameworkCore;
using Said_Project.Entities;

public class MyDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=mydatabase.db");
    }
}
