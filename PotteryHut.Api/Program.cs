using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Data;
using PotteryHut.Api.Dtos;
using PotteryHut.Api.Mappings;
using PotteryHut.Api.Entities;
using PotteryHut.Api.Helpers;

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

// POST /api/products - skapar en ny produkt. 201 med produkten, eller 400 vid valideringsfel
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

app.Run();
