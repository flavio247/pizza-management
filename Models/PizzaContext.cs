using Microsoft.EntityFrameworkCore;

namespace pizza_management.Models;

public class PizzaContext : DbContext
{
    public PizzaContext(DbContextOptions<PizzaContext> options)
        : base(options)
    {
    }

    public DbSet<Order> Order { get; set; } = null!;
    public DbSet<Pizza> Pizza { get; set; } = null!;
    public DbSet<OrderPizza> OrderPizza { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza{Id=1,Name="Margherita",Price=5},
                new Pizza{Id=2,Name="Ortolana",Price=6},
                new Pizza{Id=3,Name="Diavola",Price=6.5F},
                new Pizza{Id=4,Name="Bufalina",Price=7}
            );
        }
}

