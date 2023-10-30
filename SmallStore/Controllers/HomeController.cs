using Microsoft.AspNetCore.Mvc;
using SmallStore.Models;
using System.Diagnostics;
using BusinessLayer;
using BusinessLayer.Dtos;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmallStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StoreBusiness _storeBusiness;

        public HomeController(ILogger<HomeController> logger, StoreBusiness storeBusiness)
        {
            _logger = logger;
            _storeBusiness = storeBusiness;
        }

        public IActionResult Index()
        {
            //List<ClientDto> clientDtos = _storeBusiness.GetAllClientsAsync();

            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, int stock, decimal price)
        {
            ProductDto product = new ProductDto()
            {
                Name = name,
                Price = price,
                Stock = stock
            };

            _storeBusiness.CreateProduct(product);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}