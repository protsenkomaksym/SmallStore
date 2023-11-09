using BusinessLayer.Dtos;

namespace SmallStore.Models
{
    public class ProductsListViewModel
    {
        public List<ProductDto> Products { get; set; } = new List<ProductDto>();
    }
}
