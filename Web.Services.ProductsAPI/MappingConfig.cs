using AutoMapper;
using Web.Services.ProductsAPI.Models;
using Web.Services.ProductsAPI.Models.Dto;

namespace Web.Services.ProductsAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
