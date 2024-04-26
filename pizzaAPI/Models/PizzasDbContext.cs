using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pizzaAPI.Models;

namespace pizzaAPI.Models;

public partial class PizzasDbContext : IdentityDbContext
{
    public PizzasDbContext()
    {
    }

    public PizzasDbContext(DbContextOptions<PizzasDbContext> options)
        : base(options)
    {
    }

    

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<Promocode> Promocodes { get; set; }
    
    public virtual DbSet<Review> Reviews { get; set; }

public DbSet<pizzaAPI.Models.Order> Order { get; set; } = default!;

    
}
