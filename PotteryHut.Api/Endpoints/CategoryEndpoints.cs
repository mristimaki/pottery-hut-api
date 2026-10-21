using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Data;
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
    }
}
