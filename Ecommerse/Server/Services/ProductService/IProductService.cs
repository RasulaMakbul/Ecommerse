namespace Ecommerse.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Products>>> GetProductsAsync();
    }
}
