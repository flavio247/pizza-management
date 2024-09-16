using pizza_management.Models;

namespace pizza_management.Patterns;

public interface IOrderRepository : IDisposable{
    ICollection<Order> GetOrders();
    Order InsertOrder(Order order);
}