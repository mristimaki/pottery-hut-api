using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Data;
using PotteryHut.Api.Dtos;
using PotteryHut.Api.Entities;
using PotteryHut.Api.Helpers;
using PotteryHut.Api.Mappings;

namespace PotteryHut.Api.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this WebApplication app)
    {
        // GET /api/products - hämtar alla produkter.
        // Med ?slug= filtreras listan och returnerar 0 eller 1 produkt (alltid 200 OK)
        app.MapGet("/api/products", async (string? slug, ApplicationDbContext db) =>
        {
            var query = db.Products.AsQueryable();

            if (slug is not null)
            {
                query = query.Where(p => p.UrlSlug == slug);
            }

            var products = await query
                    .Select(p => p.ToDto())
                    .ToListAsync();

            return Results.Ok(products);
        });

        // GET /api/products/{id}
        app.MapGet("/api/products/{id:int}", async (int id, ApplicationDbContext db) =>
        {
            var product = await db.Products.FindAsync(id);

            if (product is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(product.ToDto());
        });

        // POST /api/products - skapar en ny produkt.
        app.MapPost("/api/products", async (CreateProductDto dto, ApplicationDbContext db) =>
        {
            // Validering: samlar alla fel så att de visas samtidigt
            var errors = new Dictionary<string, string[]>();

            if (string.IsNullOrWhiteSpace(dto.Name) || dto.Name.Length > 50)
            {
                errors["name"] = ["Namn måste vara mellan 1 och 50 tecken"];
            }

            if (dto.Price <= 0)
            {
                errors["price"] = ["Pris måste vara större än 0"];
            }

            if (string.IsNullOrWhiteSpace(dto.Image))
            {
                errors["image"] = ["Bild är obligatoriskt"];
            }

            if (errors.Count > 0)
            {
                return Results.ValidationProblem(errors);
            }

            // Slug: lägger till -2, -3 osv. om sluggen redan finns
            var baseSlug = SlugGenerator.Generate(dto.Name);
            var slug = baseSlug;
            var counter = 2;

            while (await db.Products.AnyAsync(p => p.UrlSlug == slug))
            {
                slug = $"{baseSlug}-{counter}";
                counter++;
            }

            var product = new Product
            {
                Name = dto.Name.Trim(),
                Description = dto.Description,
                Price = dto.Price,
                Image = dto.Image,
                UrlSlug = slug,
                CreatedAt = DateTime.UtcNow
            };

            db.Products.Add(product);
            await db.SaveChangesAsync();

            return Results.Created($"/api/products/{product.Id}", product.ToDto());
        });

        // DELETE /api/products/{id} - raderar en produkt. 204 om den raderades, 404 om den inte finns
        app.MapDelete("/api/products/{id:int}", async (int id, ApplicationDbContext db) =>
        {
            var product = await db.Products.FindAsync(id);

            if (product is null)
            {
                return Results.NotFound();
            }

            db.Products.Remove(product);
            await db.SaveChangesAsync();

            return Results.NoContent();
        });
    }
}
