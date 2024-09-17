using pizza_management.Models;

namespace pizza_management.Patterns;

public interface IOrderPizzaRepository  {
    void InsertOrderPizza(OrderPizza op);
}