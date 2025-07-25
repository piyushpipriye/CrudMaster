// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using CrudMaster.Models;

namespace CrudMaster.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

    public DbSet<Product> Products { get; set; }
}
