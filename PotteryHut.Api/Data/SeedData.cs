using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Entities;

namespace PotteryHut.Api.Data;

// Startdata för databasen: kategorier, produkter och koppling mellan dem.
// Anropas från OnModelCreating i ApplicationDbContext.
public static class SeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        // Kategorier: 1-6 är produkttyper, 7-11 är kollektioner
        // Tropical Collection skapas senare via POST /api/categories.
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Muggar", UrlSlug = "muggar" },
            new Category { Id = 2, Name = "Skålar", UrlSlug = "skalar" },
            new Category { Id = 3, Name = "Tallrikar", UrlSlug = "tallrikar" },
            new Category { Id = 4, Name = "Vaser", UrlSlug = "vaser" },
            new Category { Id = 5, Name = "Serveringsfat", UrlSlug = "serveringsfat" },
            new Category { Id = 6, Name = "Serveringsskålar", UrlSlug = "serveringsskalar" },
            new Category { Id = 7, Name = "Mud Collection", UrlSlug = "mud-collection" },
            new Category { Id = 8, Name = "Sand Collection", UrlSlug = "sand-collection" },
            new Category { Id = 9, Name = "Grass Collection", UrlSlug = "grass-collection" },
            new Category { Id = 10, Name = "Ocean Collection", UrlSlug = "ocean-collection" },
            new Category { Id = 11, Name = "Cloud Collection", UrlSlug = "cloud-collection" },
            new Category { Id = 12, Name = "Tropical Collection", UrlSlug = "tropical-collection" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Mud Vas",
                Description = "Handgjord vas ur Mud Collection, en vacker detalj till hemmet.",
                Price = 249m,
                Image = "/products/mud-vase.png",
                UrlSlug = "mud-vas",
                CreatedAt = new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 2,
                Name = "Mud Skål",
                Description = "Handgjord skål ur Mud Collection, mångsidig för både mat och dekor.",
                Price = 149m,
                Image = "/products/mud-bowl.png",
                UrlSlug = "mud-skal",
                CreatedAt = new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 3,
                Name = "Mud Mugg",
                Description = "Handgjord mugg ur Mud Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.",
                Price = 179m,
                Image = "/products/mud-mug.png",
                UrlSlug = "mud-mugg",
                CreatedAt = new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 4,
                Name = "Mud Serveringsfat Small",
                Description = "Handgjort serveringsfat ur Mud Collection, perfekt för middagsbjudningar och dekor.",
                Price = 299m,
                Image = "/products/mud-serving-bowl-small.png",
                UrlSlug = "mud-serveringsfat-small",
                CreatedAt = new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 5,
                Name = "Mud Serveringsfat Large",
                Description = "Handgjort serveringsfat ur Mud Collection, perfekt för middagsbjudningar och dekor.",
                Price = 499m,
                Image = "/products/mud-serving-bowl-large.png",
                UrlSlug = "mud-serveringsfat-large",
                CreatedAt = new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 6,
                Name = "Mud Tallrik",
                Description = "Handgjord tallrik ur Mud Collection, med en unik yta där ingen är den andra lik.",
                Price = 279m,
                Image = "/products/mud-plate.png",
                UrlSlug = "mud-tallrik",
                CreatedAt = new DateTime(2026, 9, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 7,
                Name = "Sand Mugg",
                Description = "Handgjord mugg ur Sand Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.",
                Price = 259m,
                Image = "/products/sand-mug.png",
                UrlSlug = "sand-mugg",
                CreatedAt = new DateTime(2026, 4, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 8,
                Name = "Sand Skål",
                Description = "Handgjord skål ur Sand Collection, mångsidig för både mat och dekor.",
                Price = 329m,
                Image = "/products/sand-bowl.png",
                UrlSlug = "sand-skal",
                CreatedAt = new DateTime(2026, 4, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 9,
                Name = "Sand Tallrik",
                Description = "Handgjord tallrik ur Sand Collection, med en unik yta där ingen är den andra lik.",
                Price = 289m,
                Image = "/products/sand-plate.png",
                UrlSlug = "sand-tallrik",
                CreatedAt = new DateTime(2026, 4, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 10,
                Name = "Sand Vas",
                Description = "Handgjord vas ur Sand Collection, en vacker detalj till hemmet.",
                Price = 249m,
                Image = "/products/sand-vase.png",
                UrlSlug = "sand-vas",
                CreatedAt = new DateTime(2026, 4, 21, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 11,
                Name = "Sand Serveringsfat",
                Description = "Handgjort serveringsfat ur Sand Collection, perfekt för middagsbjudningar och dekor.",
                Price = 479m,
                Image = "/products/sand-serving-plate.png",
                UrlSlug = "sand-serveringsfat",
                CreatedAt = new DateTime(2026, 4, 21, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 12,
                Name = "Grass Mugg",
                Description = "Handgjord mugg ur Grass Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.",
                Price = 179m,
                Image = "/products/grass-mug.png",
                UrlSlug = "grass-mugg",
                CreatedAt = new DateTime(2026, 3, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 13,
                Name = "Grass Skål",
                Description = "Handgjord skål ur Grass Collection, mångsidig för både mat och dekor.",
                Price = 219m,
                Image = "/products/grass-bowl.png",
                UrlSlug = "grass-skal",
                CreatedAt = new DateTime(2026, 3, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 14,
                Name = "Grass Tallrik",
                Description = "Handgjord tallrik ur Grass Collection, med en unik yta där ingen är den andra lik.",
                Price = 279m,
                Image = "/products/grass-plate.png",
                UrlSlug = "grass-tallrik",
                CreatedAt = new DateTime(2026, 3, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 15,
                Name = "Grass Serveringsskål",
                Description = "Handgjord serveringsskål ur Grass Collection, perfekt för middagsbjudningar och dekor.",
                Price = 459m,
                Image = "/products/grass-serving-bowl.png",
                UrlSlug = "grass-serveringsskal",
                CreatedAt = new DateTime(2026, 3, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 16,
                Name = "Grass Vas",
                Description = "Handgjord vas ur Grass Collection, en vacker detalj till hemmet.",
                Price = 279m,
                Image = "/products/grass-vase.png",
                UrlSlug = "grass-vas",
                CreatedAt = new DateTime(2026, 3, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 17,
                Name = "Ocean Mugg Lång",
                Description = "Handgjord mugg ur Ocean Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.",
                Price = 289m,
                Image = "/products/ocean-mug.png",
                UrlSlug = "ocean-mugg-lang",
                CreatedAt = new DateTime(2026, 8, 28, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 18,
                Name = "Ocean Mugg Rund",
                Description = "Handgjord mugg ur Ocean Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.",
                Price = 289m,
                Image = "/products/ocean-mug-round.png",
                UrlSlug = "ocean-mugg-rund",
                CreatedAt = new DateTime(2026, 8, 28, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 19,
                Name = "Ocean Vas",
                Description = "Handgjord vas ur Ocean Collection, en vacker detalj till hemmet.",
                Price = 649m,
                Image = "/products/ocean-vase.png",
                UrlSlug = "ocean-vas",
                CreatedAt = new DateTime(2026, 8, 28, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 20,
                Name = "Ocean Serveringsfat",
                Description = "Handgjort serveringsfat ur Ocean Collection, perfekt för middagsbjudningar och dekor.",
                Price = 549m,
                Image = "/products/ocean-serving-plate.png",
                UrlSlug = "ocean-serveringsfat",
                CreatedAt = new DateTime(2026, 8, 28, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 21,
                Name = "Ocean Skål",
                Description = "Handgjord skål ur Ocean Collection, mångsidig för både mat och dekor.",
                Price = 339m,
                Image = "/products/ocean-bowl.png",
                UrlSlug = "ocean-skal",
                CreatedAt = new DateTime(2026, 8, 28, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 22,
                Name = "Ocean Tallrik",
                Description = "Handgjord tallrik ur Ocean Collection, med en unik yta där ingen är den andra lik.",
                Price = 279m,
                Image = "/products/ocean-plate.png",
                UrlSlug = "ocean-tallrik",
                CreatedAt = new DateTime(2026, 10, 10, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 23,
                Name = "Cloud Mugg",
                Description = "Handgjord mugg ur Cloud Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.",
                Price = 269m,
                Image = "/products/cloud-mug.png",
                UrlSlug = "cloud-mugg",
                CreatedAt = new DateTime(2026, 2, 10, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 24,
                Name = "Cloud Skål",
                Description = "Handgjord skål ur Cloud Collection, mångsidig för både mat och dekor.",
                Price = 319m,
                Image = "/products/cloud-bowl.png",
                UrlSlug = "cloud-skal",
                CreatedAt = new DateTime(2026, 2, 10, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 25,
                Name = "Cloud Tallrik",
                Description = "Handgjord tallrik ur Cloud Collection, med en unik yta där ingen är den andra lik.",
                Price = 289m,
                Image = "/products/cloud-plate.png",
                UrlSlug = "cloud-tallrik",
                CreatedAt = new DateTime(2026, 3, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 26,
                Name = "Cloud Serveringsfat",
                Description = "Handgjort serveringsfat ur Cloud Collection, perfekt för middagsbjudningar och dekor.",
                Price = 459m,
                Image = "/products/cloud-serving-plate.png",
                UrlSlug = "cloud-serveringsfat",
                CreatedAt = new DateTime(2026, 10, 10, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 27,
                Name = "Cloud Vas",
                Description = "Handgjord vas ur Cloud Collection, en vacker detalj till hemmet.",
                Price = 289m,
                Image = "/products/cloud-vase.png",
                UrlSlug = "cloud-vas",
                CreatedAt = new DateTime(2026, 3, 23, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 28,
                Name = "Tropical Mugg",
                Description = "Handgjord mugg ur Tropical Collection, perfekt för morgonkaffet. Varje mugg är unik och formad för hand.",
                Price = 279m,
                Image = "/products/tropical-mug.png",
                UrlSlug = "tropical-mugg",
                CreatedAt = new DateTime(2026, 1, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 29,
                Name = "Tropical Skål",
                Description = "Handgjord skål ur Tropical Collection, mångsidig för både mat och dekor.",
                Price = 339m,
                Image = "/products/tropical-bowl.png",
                UrlSlug = "tropical-skal",
                CreatedAt = new DateTime(2026, 1, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 30,
                Name = "Tropical Serveringsfat",
                Description = "Handgjort serveringsfat ur Tropical Collection, perfekt för middagsbjudningar och dekor.",
                Price = 579m,
                Image = "/products/tropical-serving-plate.png",
                UrlSlug = "tropical-serveringsfat",
                CreatedAt = new DateTime(2026, 1, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 31,
                Name = "Tropical Serveringsskål",
                Description = "Handgjord serveringsskål ur Tropical Collection, perfekt för middagsbjudningar och dekor.",
                Price = 459m,
                Image = "/products/tropical-serving-bowl.png",
                UrlSlug = "tropical-serveringsskal",
                CreatedAt = new DateTime(2026, 1, 15, 0, 0, 0, DateTimeKind.Utc)
            },
            new Product
            {
                Id = 32,
                Name = "Tropical Tallrik",
                Description = "Handgjord tallrik ur Tropical Collection, med en unik yta där ingen är den andra lik.",
                Price = 299m,
                Image = "/products/tropical-plate.png",
                UrlSlug = "tropical-tallrik",
                CreatedAt = new DateTime(2026, 1, 15, 0, 0, 0, DateTimeKind.Utc)
            }
        );

        // Kopplingstabellen: varje produkt ligger i sin typ och sin kollektion.
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Categories)
            .WithMany(c => c.Products)
            .UsingEntity(j => j.HasData(
            new { ProductsId = 1, CategoriesId = 4 }, new { ProductsId = 1, CategoriesId = 7 },
            new { ProductsId = 2, CategoriesId = 2 }, new { ProductsId = 2, CategoriesId = 7 },
            new { ProductsId = 3, CategoriesId = 1 }, new { ProductsId = 3, CategoriesId = 7 },
            new { ProductsId = 4, CategoriesId = 5 }, new { ProductsId = 4, CategoriesId = 7 },
            new { ProductsId = 5, CategoriesId = 5 }, new { ProductsId = 5, CategoriesId = 7 },
            new { ProductsId = 6, CategoriesId = 3 }, new { ProductsId = 6, CategoriesId = 7 },
            new { ProductsId = 7, CategoriesId = 1 }, new { ProductsId = 7, CategoriesId = 8 },
            new { ProductsId = 8, CategoriesId = 2 }, new { ProductsId = 8, CategoriesId = 8 },
            new { ProductsId = 9, CategoriesId = 3 }, new { ProductsId = 9, CategoriesId = 8 },
            new { ProductsId = 10, CategoriesId = 4 }, new { ProductsId = 10, CategoriesId = 8 },
            new { ProductsId = 11, CategoriesId = 5 }, new { ProductsId = 11, CategoriesId = 8 },
            new { ProductsId = 12, CategoriesId = 1 }, new { ProductsId = 12, CategoriesId = 9 },
            new { ProductsId = 13, CategoriesId = 2 }, new { ProductsId = 13, CategoriesId = 9 },
            new { ProductsId = 14, CategoriesId = 3 }, new { ProductsId = 14, CategoriesId = 9 },
            new { ProductsId = 15, CategoriesId = 6 }, new { ProductsId = 15, CategoriesId = 9 },
            new { ProductsId = 16, CategoriesId = 4 }, new { ProductsId = 16, CategoriesId = 9 },
            new { ProductsId = 17, CategoriesId = 1 }, new { ProductsId = 17, CategoriesId = 10 },
            new { ProductsId = 18, CategoriesId = 1 }, new { ProductsId = 18, CategoriesId = 10 },
            new { ProductsId = 19, CategoriesId = 4 }, new { ProductsId = 19, CategoriesId = 10 },
            new { ProductsId = 20, CategoriesId = 5 }, new { ProductsId = 20, CategoriesId = 10 },
            new { ProductsId = 21, CategoriesId = 2 }, new { ProductsId = 21, CategoriesId = 10 },
            new { ProductsId = 22, CategoriesId = 3 }, new { ProductsId = 22, CategoriesId = 10 },
            new { ProductsId = 23, CategoriesId = 1 }, new { ProductsId = 23, CategoriesId = 11 },
            new { ProductsId = 24, CategoriesId = 2 }, new { ProductsId = 24, CategoriesId = 11 },
            new { ProductsId = 25, CategoriesId = 3 }, new { ProductsId = 25, CategoriesId = 11 },
            new { ProductsId = 26, CategoriesId = 5 }, new { ProductsId = 26, CategoriesId = 11 },
            new { ProductsId = 27, CategoriesId = 4 }, new { ProductsId = 27, CategoriesId = 11 },
            new { ProductsId = 28, CategoriesId = 1 }, new { ProductsId = 28, CategoriesId = 12 },
            new { ProductsId = 29, CategoriesId = 2 }, new { ProductsId = 29, CategoriesId = 12 },
            new { ProductsId = 30, CategoriesId = 5 }, new { ProductsId = 30, CategoriesId = 12 },
            new { ProductsId = 31, CategoriesId = 6 }, new { ProductsId = 31, CategoriesId = 12 },
            new { ProductsId = 32, CategoriesId = 3 }, new { ProductsId = 32, CategoriesId = 12 }
            ));
    }
}
