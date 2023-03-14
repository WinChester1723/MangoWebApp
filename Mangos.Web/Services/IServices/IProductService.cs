using Mango.Web.Models;

namespace Mangos.Web.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto productDto);
        Task<T> UpdateProductAsync<T>(ProductDto productDto6);
        Task<T> DeleteProductAsync<T>(int id);

    }
}
