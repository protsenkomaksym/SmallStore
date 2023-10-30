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

        public void CreateProduct(Product p)
        {
            _context.Products.AddAsync(p);
            _context.SaveChanges();
        }
    }
}
