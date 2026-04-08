using EComerceViewComponent.Models;
namespace EComerceViewComponent.Pages.Shared.Services
{
    public class ProductService
    {
        List<Product> Products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Vivo S9 5G", Price = 10.99m, Description = "Vivo" },
            new Product() { Id = 2, Name = "Xiaomi Mi 11T 5G", Price = 19.99m, Description = "Xiaomi" },
            new Product() { Id = 3, Name = "OPPO K9 PRO", Price = 5.99m, Description = "OPPO" }
        };
    }

    public List<Product> GetProducts()
    {
        return this.Products;
    }


}