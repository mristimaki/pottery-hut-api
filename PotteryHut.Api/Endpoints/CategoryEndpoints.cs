using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Data;
using PotteryHut.Api.Dtos;
using PotteryHut.Api.Entities;
using PotteryHut.Api.Helpers;
using PotteryHut.Api.Mappings;

namespace PotteryHut.Api.Endpoints;

public static class CategoryEndpoints
{
    public static void MapCategoryEndpoints(this WebApplication app)
    {
        // GET /api/categories - hämtar alla kategorier med deras produkter
        // Med ?slug= filtreras listan och returnerar 0 eller 1 kategori (alltid 200 OK)
        app.MapGet("/api/categories", async (string? slug, ApplicationDbContext db) =>
        {
            var query = db.Categories
                .Include(c => c.Products)
                .AsQueryable();

            if (slug is not null)
            {
                query = query.Where(c => c.UrlSlug == slug);
            }

            var categories = await query.ToListAsync();

            return Results.Ok(categories.Select(c => c.ToDto()));
        });

        // GET /api/categories/{id:int} - hämtar en kategori med dess produkter.
        app.MapGet("/api/categories/{id:int}", async (int id, ApplicationDbContext db) =>
        {
            var category = await db.Categories
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(category.ToDto());
        });

        // POST /api/categories - skapar en ny kategori
        app.MapPost("/api/categories", async (CreateCategoryDto dto, ApplicationDbContext db) =>
        {
            // Validering: samlar alla fel så att de visas samtidigt
            var errors = new Dictionary<string, string[]>();

            if (string.IsNullOrWhiteSpace(dto.Name) || dto.Name.Length > 50)
            {
                errors["name"] = ["Namn måste vara mellan 1 och 50 tecken"];
            }

            if (errors.Count > 0)
            {
                return Results.ValidationProblem(errors);
            }

            // Slug: lägger till -2, -3 osv. om sluggen redan finns
            var baseSlug = SlugGenerator.Generate(dto.Name);
            var slug = baseSlug;
            var counter = 2;

            while (await db.Categories.AnyAsync(c => c.UrlSlug == slug))
            {
                slug = $"{baseSlug}-{counter}";
                counter++;
            }

            var category = new Category
            {
                Name = dto.Name.Trim(),
                Image = dto.Image,
                UrlSlug = slug
            };

            db.Categories.Add(category);
            await db.SaveChangesAsync();

            return Results.Created($"/api/categories/{category.Id}", category.ToDto());
        });

        // DELETE /api/categories/{id:int}
        app.MapDelete("/api/categories/{id:int}", async (int id, ApplicationDbContext db) =>
        {
            var category = await db.Categories.FindAsync(id);

            if (category is null)
            {
                return Results.NotFound();
            }

            db.Categories.Remove(category);
            await db.SaveChangesAsync();

            return Results.NoContent();
        });
    }
}
