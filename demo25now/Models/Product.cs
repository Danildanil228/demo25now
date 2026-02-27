using System;
using System.Collections.Generic;

namespace demo25now.Models;

public partial class Product
{
    public string ProductName { get; set; } = null!;

    public decimal Cost { get; set; }

    public string? Description { get; set; }

    public string? MainImagePath { get; set; }

    public bool IsActive { get; set; }

    public string? ManufactureName { get; set; }

    public virtual Manufacture? ManufactureNameNavigation { get; set; }

    public virtual ICollection<Productsale> Productsales { get; set; } = new List<Productsale>();
}
