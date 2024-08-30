using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SimpleFakeStoreApp.Models;

namespace SimpleFakeStoreApp.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://fakestoreapi.com/"); // Temel API adresi
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            try
            {
                // "products" uç noktasına GET isteği
                var response = await _httpClient.GetStringAsync("products");
                return JsonSerializer.Deserialize<List<Product>>(response);
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON Deserialize Error: {ex.Message}");
                return new List<Product>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                return new List<Product>();
            }
        }
    }
}
