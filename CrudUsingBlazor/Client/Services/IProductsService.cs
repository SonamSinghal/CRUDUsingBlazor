using CrudUsingBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudUsingBlazor.Client.Services
{
    public interface IProductsService
    {
        Task<List<ProductModel>> GetProductModelsAsync();
        Task<ProductModel> ProductDetailsAsync(Guid id);
        Task<ProductModel> CreateProductAsync(ProductModel product);
        Task<ProductModel> UpdateProductAsync(Guid id, ProductModel product);
        Task DeleteProductAsync(Guid id);
    }
}