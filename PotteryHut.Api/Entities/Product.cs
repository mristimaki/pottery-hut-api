namespace PotteryHut.Api.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; } = string.Empty;
    public string UrlSlug { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public List<Category> Categories { get; set; } = [];
}
