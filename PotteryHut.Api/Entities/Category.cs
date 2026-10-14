namespace PotteryHut.Api.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Image { get; set; }
    public string UrlSlug { get; set; } = string.Empty;

    public List<Product> Products { get; set; } = [];
}
