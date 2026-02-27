using System;
using System.Collections.Generic;

namespace demo25now.Models;

public partial class Manufacture
{
    public string ManufactureName { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
