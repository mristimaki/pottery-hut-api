using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Entities;

namespace PotteryHut.Api.Data;

// Kopplingen mellan applikationen och databasen, som ärver från DbContext-klassen.
// Varje DbSet representerar en tabell i databasen.
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(10, 2);

        modelBuilder.Entity<Product>()
            .HasIndex(p => p.UrlSlug)
            .IsUnique();

        modelBuilder.Entity<Category>()
            .HasIndex(c => c.UrlSlug)
            .IsUnique();
    }
}
