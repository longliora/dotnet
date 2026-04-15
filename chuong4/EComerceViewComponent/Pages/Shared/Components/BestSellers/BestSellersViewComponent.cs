
using EComerceViewComponent.Pages.Shared.Components.ProductList;
using Microsoft.AspNetCore.Mvc;

namespace EComerceViewComponent.Pages.Shared.Components.BestSellers
{
    public class BestSellersViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var allBestSellers = new List<string>
            {
                "Product A",
                "Product B",
                "Product C",
                "Product D",
                "Product E"
            };
            await Task.Delay(10); // Simulate asynchronous operation
            var BestSellers = allBestSellers.Take(count).ToList();
            return View(BestSellers);
        }
    }
}