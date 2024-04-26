using System;
using System.Collections.Generic;

namespace pizzaAPI.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public decimal TotalPrice { get; set; }

    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Apartment { get; set; } = null!;

    public string Floor { get; set; } = null!;

    public string PaymentType { get; set; } = null!;

    public string? OrderComment { get; set; }

    public string OrderStatus { get; set; } = string.Empty;

}
