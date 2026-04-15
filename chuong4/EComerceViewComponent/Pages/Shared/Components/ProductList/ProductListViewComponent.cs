using EComerceViewComponent.Pages.Shared.Services;
using EComerceViewComponent.Models;
using Microsoft.AspNetCore.Mvc;
namespace EComerceViewComponent.Pages.Shared.Components.ProductList
{
    public class ProductListViewComponent : ViewComponent
    {
        List<Product>  products;
        public ProductListViewComponent(ProductService productService)
        {   //lấy danh sách sản phẩm từ ProductService và gán cho biến products
            products = productService.GetProducts();
        }

        //phương thức bất đồng bộ để trả về một kết quả hiển thị (IViewComponentResult) chứa danh sách sản phẩm
        public async Task<IViewComponentResult> InvokeAsync(bool sapXepTang = true)
        {
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