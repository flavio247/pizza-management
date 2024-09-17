using Microsoft.EntityFrameworkCore;
using pizza_management.Models;
using pizza_management.Patterns;

namespace pizza_management.Patterns;

public class OrderPizzaRepository(PizzaContext context) : BaseRepository(context), IOrderPizzaRepository
{
    public void InsertOrderPizza(OrderPizza op)
    {
        context.Add(op);
        context.SaveChanges();
    }

}