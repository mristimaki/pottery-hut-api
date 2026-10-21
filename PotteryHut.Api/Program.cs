using Microsoft.EntityFrameworkCore;
using PotteryHut.Api.Data;
using PotteryHut.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// --- Tjänster (registreras i DI-containern före Build) ---

// Databasen: ApplicationDbContext mot SQL Server, via connection string i appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// CORS: tillåter anrop från Angular-frontenden (localhost:4200),
// som annars blockeras av webbläsaren eftersom den körs på en annan port än API:et
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

// --- Pipeline (middleware körs i den ordning de står, före endpoints) ---

app.UseHttpsRedirection();
app.UseCors("AllowAngular");

// --- Endpoints ---

app.MapProductEndpoints();

app.Run();
