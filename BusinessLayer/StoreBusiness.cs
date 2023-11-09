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

        public async Task<List<ProductDto>> GetAllProductsAsync()
        {
            List<Product> products = await _storeData.GetAllProducts();
            List<ProductDto> productsDto = new List<ProductDto>();

            if (products != null && products.Count > 0)
            {
                foreach (Product p in products)
                {
                    ProductDto productDto = new ProductDto();
                    productDto.Id = p.Id;
                    productDto.Name = p.Name;
                    productDto.Stock = p.Stock;
                    productDto.Price = p.Price;
                    productsDto.Add(productDto);
                }
            }

            return productsDto;
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
