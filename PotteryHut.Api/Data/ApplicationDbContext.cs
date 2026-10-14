using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Entities;

namespace PotteryHut.Api.Data;


public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
