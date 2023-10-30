using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Stock { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<ProductClient> ProductClients { get; set; } = new List<ProductClient>();
}
