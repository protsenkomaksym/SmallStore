using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class ProductClient
{
    public int Id { get; set; }

    public int IdProduct { get; set; }

    public int IdClient { get; set; }

    public int Quantity { get; set; }

    public decimal totalPrice { get; set; }

    public DateTime Created { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
