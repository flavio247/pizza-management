using Microsoft.EntityFrameworkCore;
using pizza_management.Models;
using pizza_management.Patterns;

namespace pizza_management.Patterns;

public class OrderRepository : BaseRepository , IOrderRepository
{
    public OrderRepository(PizzaContext context):base(context)
    {
        this.context=context;
    }

    public ICollection<Order> GetOrders()
    {
        return context.Order.Include(x=>x.OrderPizzas).ThenInclude(x=>x.Pizza).ToList();
    }

    public Order InsertOrder(Order order)
    {
        context.Add(order);
        context.SaveChanges();
        return order;
    }

}