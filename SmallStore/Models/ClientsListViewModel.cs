using BusinessLayer.Dtos;

namespace SmallStore.Models
{
    public class ClientsListViewModel
    {
        public List<ClientDto> Clients { get; set; } = new List<ClientDto>();
    }
}
