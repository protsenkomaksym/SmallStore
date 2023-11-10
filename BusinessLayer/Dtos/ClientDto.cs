using DataLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public decimal totalAmount { get; set; }

        public virtual ICollection<ProductClient> ProductClients { get; set; } = new List<ProductClient>();
    }
}



