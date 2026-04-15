using Microsoft.AspNetCore.Mvc;
using EComerceViewComponent.Pages.Shared.Services;
using EComerceViewComponent.Models;
public class ProductViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string category)
    {
        var products = await GetProductsAsync(category);
        return View(products);
    }
    public Task<List<string>> GetProductsAsync(string category)
    {
        var allProducts = new Dictionary<string, List<string>>
        {
            { "Vivo", new List<string> { "Vivo S9 5G", "Vivo Y77" , "Vivo V21" } },
        { "Xiaomi", new List<string> { "Xiaomi Mi 11T 5G", "Xiaomi Redmi Note 10" , "Xiaomi Poco F3" } },
            { "Apple", new List<string> { "Apple iPhone 13", "Apple iPhone 13 Pro", "Apple iPhone 13 Pro Max" } }
        };
        return Task.FromResult(allProducts.ContainsKey(category) ? allProducts[category] : new List<string>());
    }
}