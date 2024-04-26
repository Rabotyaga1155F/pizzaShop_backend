using System;
using System.Collections.Generic;

namespace pizzaAPI.Models;

public partial class Promocode
{
    public int PromocodeId { get; set; }

    public string Promocode1 { get; set; } = null!;

    public int PercentageDiscount { get; set; }
}
