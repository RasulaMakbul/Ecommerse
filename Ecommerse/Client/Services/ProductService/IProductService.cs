﻿namespace Ecommerse.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Products> Products { get; set; }
        Task GetProducts();
    }
}
