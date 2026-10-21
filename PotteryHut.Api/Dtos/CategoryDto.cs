namespace PotteryHut.Api.Dtos;

public record CategoryDto(
    int Id,
    string Name,
    string? Image,
    string UrlSlug,
    List<ProductDto> Products);
