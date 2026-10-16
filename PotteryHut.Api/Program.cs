using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Data;
using PotteryHut.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// CORS: tillåter anrop från Angular-frontenden (localhost:4200)
// som annars blockeras av webbläsaren eftersom den körs på annan port än API:et
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("AllowAngular");

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

// Get /api/products - hämtar alla produkter.
// Med ?slug= filtreras listan och returnerar 0 eller 1 produkt (alltid 200 OK).
app.MapGet("/api/products", async (string? slug, ApplicationDbContext db) =>
{
    var query = db.Products.AsQueryable();

    if (slug is not null)
    {
        query = query.Where(p => p.UrlSlug == slug);
    }

    var products = await query
            .Select(p => new ProductDto(
            p.Id,
            p.Name,
            p.Description,
            p.Price,
            p.Image,
            p.UrlSlug,
            p.CreatedAt))
        .ToListAsync();

    return Results.Ok(products);
});

app.Run();
