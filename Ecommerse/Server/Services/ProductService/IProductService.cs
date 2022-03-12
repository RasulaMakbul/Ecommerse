namespace Ecommerse.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Products>>> GetProductsAsync();
        Task<ServiceResponse<Products>>GetProductAsync(int productId);
    }
}
