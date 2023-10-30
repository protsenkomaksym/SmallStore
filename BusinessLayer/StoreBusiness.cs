using BusinessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer
{
    public class StoreBusiness
    {
        private readonly StoreData _storeData;

        public StoreBusiness(StoreData storeData)
        {
            _storeData = storeData;
        }

        public async Task<List<ClientDto>> GetAllClientsAsync()
        {
            List<Client> clients = await _storeData.GetAllClients();
            List<ClientDto> clientsDto = new List<ClientDto>();

            if (clients != null && clients.Count > 0)
            {
                foreach (Client c in clients)
                {
                    ClientDto clientDto = new ClientDto();
                    clientDto.Id = c.Id;
                    clientDto.FullName = c.FullName;
                    clientsDto.Add(clientDto);
                }
            }

            return clientsDto;
        }

        public void CreateProduct(ProductDto p)
        {
            Product product = new Product()
            {
                Name = p.Name,
                Price = p.Price,
                Stock = p.Stock
            };

            _storeData.CreateProduct(product);
        }
    }
}
