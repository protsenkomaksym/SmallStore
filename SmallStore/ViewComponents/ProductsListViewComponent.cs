using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using SmallStore.Models;

namespace SmallStore.ViewComponents
{
    public class ProductsListViewComponent: ViewComponent
    {
        private readonly StoreBusiness _storeBusiness;

        public ProductsListViewComponent(StoreBusiness storeBusiness)
        {
            _storeBusiness = storeBusiness;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Your logic for preparing data
            ProductsListViewModel model = new ProductsListViewModel();

            model.Products = await _storeBusiness.GetAllProductsAsync();

            return View(model);
        }
    }
}
