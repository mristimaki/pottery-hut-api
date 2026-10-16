using PotteryHut.Api.Dtos;
using PotteryHut.Api.Entities;

namespace PotteryHut.Api.Mappings;

public static class ProductMappings
{
    public static ProductDto ToDto(this Product product) =>
        new(
            product.Id,
            product.Name,
            product.Description,
            product.Price,
            product.Image,
            product.UrlSlug,
            product.CreatedAt);
}
