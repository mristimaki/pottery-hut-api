namespace PotteryHut.Api.Dtos;

public record CreateProductDto(
    string Name,
    string? Description,
    decimal Price,
    string Image);
