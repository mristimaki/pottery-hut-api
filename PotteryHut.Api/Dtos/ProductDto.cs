namespace PotteryHut.Api.Dtos;

public record ProductDto(
    int Id,
    string Name,
    string? Description,
    decimal Price,
    string Image,
    string UrlSlug,
    DateTime CreatedAt);
