using CrudUsingBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudUsingBlazor.Server.Repository
{
    public interface IProductRepository
    {
        Task CreateProductAsync(ProductModel model);
        void DeleteProduct(Guid id);
        Task<List<ProductModel>> GetAllProductsAsync();
        Task<ProductModel> GetProductAsync(Guid id);
        Task<ProductModel> UpdateProductAsync(Guid id, ProductModel model);
        
    }
}