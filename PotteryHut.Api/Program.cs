using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Data;
using PotteryHut.Api.Dtos;
using PotteryHut.Api.Mappings;

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
            .Select(p => p.ToDto())
            .ToListAsync();

    return Results.Ok(products);
});

// GET /api/products/{id} - hämtar en produkt. 404 Not found om den inte finns.
app.MapGet("/api/products/{id:int}", async (int id, ApplicationDbContext db) =>
{
    var product = await db.Products.FindAsync(id);

    return product is null
        ? Results.NotFound()
        : Results.Ok(product.ToDto());
});

app.Run();
