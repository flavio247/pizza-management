using Microsoft.EntityFrameworkCore;
using pizza_management.Models;
using pizza_management.Patterns;

namespace pizza_management.Patterns;

public class OrderPizzaRepository : BaseRepository, IOrderPizzaRepository
{
    public OrderPizzaRepository(PizzaContext context):base(context)
    {

    }

    public void InsertOrderPizza(OrderPizza op)
    {
        context.Add(op);
        context.SaveChanges();
    }

}