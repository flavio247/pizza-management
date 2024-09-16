using pizza_management.Models;

namespace pizza_management.Patterns;

public interface IOrderPizzaRepository : IDisposable {
    void InsertOrderPizza(OrderPizza op);
}