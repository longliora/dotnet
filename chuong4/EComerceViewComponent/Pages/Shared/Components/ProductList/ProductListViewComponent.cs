using EComerceViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace EComerceViewComponent.Pages.Shared.Components.ProductList
{
    public class ProductListViewComponent : ViewComponent
    {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Vivo S9 5G", Price = 10.99m, Description = "Vivo" },
                new Product() { Id = 2, Name = "Xiaomi Mi 11T 5G", Price = 19.99m, Description = "Xiaomi" },
                new Product() { Id = 3, Name = "OPPO K9 PRO", Price = 5.99m, Description = "OPPO" }
            };


        //phương thức bất đồng bộ để trả về một kết quả hiển thị (IViewComponentResult) chứa danh sách sản phẩm
        public async Task<IViewComponentResult> InvokeAsync()
        {

            bool sapXepTang = true;
            if (sapXepTang)
            {
                products = products.OrderBy(p => p.Price).ToList();
            }
            else
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }
            return View(products);
        }


    };

}