using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dtos
{
    public class ProductClientDto
    {
        public int Id { get; set; }

        public int IdProduct { get; set; }

        public int IdClient { get; set; }

        public int Quantity { get; set; }

        public decimal totalPrice { get; set; }

        public DateTime Created { get; set; }

        public string FullName { get; set; } = null!;

        public string ProductName { get; set; } = null!;
    }
}
