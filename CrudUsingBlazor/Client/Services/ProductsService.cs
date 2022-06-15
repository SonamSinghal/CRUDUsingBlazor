using CrudUsingBlazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CrudUsingBlazor.Client.Services
{
    public class ProductsService : IProductsService
    {
        private readonly HttpClient _httpClient;

        public ProductsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductModel> CreateProductAsync(ProductModel product)
         {
            var data = await _httpClient.PostAsJsonAsync<ProductModel>("Products/createProduct", product);
            var result = await data.Content.ReadFromJsonAsync<ProductModel>();
            return result;
        }

        public async Task DeleteProductAsync(Guid id)
        {
            await _httpClient.DeleteAsync($"Products/deleteProduct/{id}");
        }

        public async Task<List<ProductModel>> GetProductModelsAsync()
        {
            var data = await _httpClient.GetFromJsonAsync<List<ProductModel>>("Products/allProducts");
            return data;
        }

        public async Task<ProductModel> ProductDetailsAsync(Guid id)
        {
            var data = await _httpClient.GetFromJsonAsync<ProductModel>($"Products/productDetails/{id}");
            return data;
        }

        public async Task<ProductModel> UpdateProductAsync(Guid id, ProductModel product)
        {
            var data = await _httpClient.PutAsJsonAsync<ProductModel>($"Products/updateProduct/{id}", product);
            var result = await data.Content.ReadFromJsonAsync<ProductModel>();
            return result;
        }
    }
}