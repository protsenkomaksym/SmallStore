using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Client
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public virtual ICollection<ProductClient> ProductClients { get; set; } = new List<ProductClient>();
}
