# The Pottery Hut API

REST API for **The Pottery Hut**, a web shop for handmade ceramics. Built with ASP.NET Core Minimal API, Entity Framework Core and SQL Server.
 
The API serves products and categories (product types such as mugs and plates, and collections such as Mud Collection and Ocean Collection). It was built as a course project in *Backend Development 2* at EC Utbildning, as the backend for an existing Angular frontend.

## Tech stack
 
- **C# / .NET 10**
- **ASP.NET Core Minimal API**
- **Entity Framework Core** with code-first migrations
- **SQL Server LocalDB**

## Features
 
- CRUD endpoints for products and categories
- Many-to-many relationship between products and categories (a product belongs to both a type and a collection)
- URL slugs generated on the backend, including Swedish characters (`Mud Skål` → `mud-skal`) and unique suffixes for duplicates (`-2`, `-3`)
- Validation with all errors returned at once in ProblemDetails format (400 Bad Request)
- DTOs for all responses, so entities are never exposed directly
- Seed data with 32 products in 12 categories
- CORS configured for the Angular frontend (`http://localhost:4200`)

## Endpoints
 
### Products
 
| Method | Endpoint | Description | Responses |
| --- | --- | --- | --- |
| GET | `/api/products` | Get all products | 200 |
| GET | `/api/products?slug={slug}` | Get products by URL slug (list with 0 or 1 product) | 200 |
| GET | `/api/products/{id}` | Get a product by id | 200, 404 |
| POST | `/api/products` | Create a product | 201, 400 |
| DELETE | `/api/products/{id}` | Delete a product | 204, 404 |
 
### Categories
 
Category responses include the category's products.
 
| Method | Endpoint | Description | Responses |
| --- | --- | --- | --- |
| GET | `/api/categories` | Get all categories | 200 |
| GET | `/api/categories?slug={slug}` | Get categories by URL slug (list with 0 or 1 category) | 200 |
| GET | `/api/categories/{id}` | Get a category by id | 200, 404 |
| POST | `/api/categories` | Create a category | 201, 400 |
| DELETE | `/api/categories/{id}` | Delete a category (its products are kept) | 204, 404 |

### Example: create a product
 
```http
POST /api/products
Content-Type: application/json
 
{
  "name": "Sand Mugg",
  "description": "Handmade mug from Sand Collection.",
  "price": 259,
  "image": "/products/sand-mug.png"
}
```

Response `201 Created`:

```json
{
  "id": 33,
  "name": "Sand Mugg",
  "description": "Handmade mug from Sand Collection.",
  "price": 259,
  "image": "/products/sand-mug.png",
  "urlSlug": "sand-mugg",
  "createdAt": "2026-10-23T12:00:00Z"
}
```

Validation rules: `name` is required (1–50 characters), `price` must be greater than 0 and `image` is required for products. `description` is optional. For categories, only `name` is required.

## Getting started
 
### Prerequisites
 
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server LocalDB (included with Visual Studio)
### Run the project
 
1. Clone the repository:
```bash
   git clone https://github.com/mristimaki/pottery-hut-api.git
```
2. Create the database and seed data. In Visual Studio, open the Package Manager Console and run:
```
   Update-Database
```
   Or from a terminal in the `PotteryHut.Api` folder:
```bash
   dotnet ef database update
```
3. Start the API with the `https` profile. It runs on `https://localhost:8000`.
4. Try the endpoints with `PotteryHut.Api.http` in Visual Studio: open the file and click **Send request** above a request.
The connection string is in `appsettings.json` and points to LocalDB:
 
```json
"ConnectionStrings": {
  "Default": "Server=(localdb)\\MSSQLLocalDB;Database=PotteryHut;Trusted_Connection=True;"
}
```

## Project structure
 
```
PotteryHut.Api/
├── Data/           ApplicationDbContext and seed data
├── Dtos/           Records for data sent to and from the API
├── Endpoints/      ProductEndpoints and CategoryEndpoints (Minimal API)
├── Entities/       Product and Category (database tables)
├── Helpers/        SlugGenerator
├── Mappings/       Extension methods that convert entities to DTOs
├── Migrations/     EF Core migrations
├── Program.cs      Services, middleware and endpoint registration
└── PotteryHut.Api.http   Test requests for every endpoint
```

## Design decisions
 
- **Minimal API** instead of controllers, with endpoints grouped in one file per resource.
- **Records for DTOs** that only carry data, and classes where an object needs to change after it is created.
- **Validation in the endpoints** with a dictionary and `Results.ValidationProblem`, so the client gets every error at once.
- **Seed data with `HasData`**, so the data is part of the migrations and the same for everyone who runs `Update-Database`.
- **`CreatedAt` set by the backend**, used by the frontend to show a "new" badge on products less than 7 days old.

## Possible next steps
 
- Connect the Angular frontend to the API
- Pagination for products
- Update products and categories with PATCH
- Endpoints for adding and removing products in a category
- Shopping cart endpoints
- API documentation with OpenAPI and Scalar


## AI assistance

I used Claude (Anthropic) as support for debugging, explaining concepts and converting my frontend seed data to C#. 
The code and design decisions are my own.