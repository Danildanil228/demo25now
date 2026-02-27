using System;
using System.Collections.Generic;

namespace demo25now.Models;

public partial class Productsale
{
    public int Id { get; set; }

    public DateTime SaleDate { get; set; }

    public string? ProductName { get; set; }

    public int Quantity { get; set; }

    public virtual Product? ProductNameNavigation { get; set; }
}
