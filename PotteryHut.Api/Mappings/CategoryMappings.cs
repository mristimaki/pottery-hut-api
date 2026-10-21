using PotteryHut.Api.Dtos;
using PotteryHut.Api.Entities;

namespace PotteryHut.Api.Mappings;

public static class CategoryMappings
{
    public static CategoryDto ToDto(this Category category) =>
        new(
            category.Id,
            category.Name,
            category.Image,
            category.UrlSlug,
            category.Products.Select(p => p.ToDto()).ToList());
}
