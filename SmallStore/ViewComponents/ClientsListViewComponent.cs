using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using SmallStore.Models;

namespace SmallStore.ViewComponents
{
    public class ClientsListViewComponent : ViewComponent
    {
        private readonly StoreBusiness _storeBusiness;

        public ClientsListViewComponent(StoreBusiness storeBusiness)
        {
            _storeBusiness = storeBusiness;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Your logic for preparing data
            ClientsListViewModel model = new ClientsListViewModel();

            model.Clients = await _storeBusiness.GetAllClientsAsync();

            return View(model);
        }

        //public IViewComponentResult Invoke()
        //{
        //    // Your logic for preparing data
        //    ClientsListViewModel model = new ClientsListViewModel();

        //    model.Clients = _storeBusiness.GetAllClientsAsync();

        //    return View(model);
        //}
    }
}
