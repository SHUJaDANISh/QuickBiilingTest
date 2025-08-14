using QuickBiilingTest.Models.Dto;
using QuickBiilingTest.Models.Entities;

namespace QuickBiilingTest.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<int> CreateProduct(ProductDto productDto);
        Task<int> UpdateProduct(int id, ProductDto productDto);
        Task<int> DeleteProduct(int id);
    }
}
