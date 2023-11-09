using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StoreData
    {
        private readonly SmallStoreContext _context;

        public StoreData(SmallStoreContext smallStoreContext)
        {
            _context = smallStoreContext;
        }

        public async Task<List<Client>> GetAllClients()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public List<ProductClient> GetAllTransactions()
        {
            return _context.ProductClients
                .Include(x => x.IdClientNavigation)
                .Include(x => x.IdProductNavigation).ToList();
        }

        public void CreateProduct(Product p)
        {
            _context.Products.AddAsync(p);
            _context.SaveChanges();
        }
    }
}
