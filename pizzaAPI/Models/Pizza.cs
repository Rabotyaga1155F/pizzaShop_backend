using System;
using System.Collections.Generic;

namespace pizzaAPI.Models;

public partial class Pizza
{
    public int PizzaId { get; set; }

    public string PizzaName { get; set; } = null!;

    public string PizzaDescription { get; set; } = null!;

    public decimal PizzaPrice { get; set; }

    public string Image { get; set; } = null!;
}
