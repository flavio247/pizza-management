using pizza_management.Controllers.Resources;
using pizza_management.Models;
using pizza_management.Patterns;

namespace pizza_management.Persistance;
public class OrderService : IOrderService
{
    private readonly IOrderRepository orderRepository;
    private readonly IOrderPizzaRepository orderPizzaRepository;

    public OrderService(IOrderRepository orderRepository,IOrderPizzaRepository orderPizzaRepository)
    {
        this.orderPizzaRepository=orderPizzaRepository;
        this.orderRepository=orderRepository;
    }

    public OrderDto GetLastOrder()
    {
        var order = orderRepository.GetOrders()
                                .Where(x => !x.Completed)
                                .OrderBy(x => x.OrderTime)
                                .FirstOrDefault();

        if(order!=null){
            return new(){
                Id=order.Id,
                Pizze=order.OrderPizzas.Select(x=>new PizzaDto(){Name=x.Pizza.Name}).ToList()
            };
        }
        return new();
    }

    public OrderRes Save(OrderReq req)
    {
        var order=orderRepository.InsertOrder(new(){
            Completed=false,
            OrderTime=DateTime.Now
        });
        foreach (var pizzaId in req.PizzaId)
        {
            orderPizzaRepository.InsertOrderPizza(new(){
                OrderId=order.Id,
                PizzaId=pizzaId
            });
        }
        var pendingOrders = orderRepository.GetOrders()
                                .Where(x => !x.Completed && x.Id!=order.Id)
                                .Count();
        var total = orderRepository.GetOrders()
                                    .Where(x => x.Id==order.Id)
                                    .First()
                                    .OrderPizzas
                                    .Select(x=>x.Pizza?.Price??0)
                                    .Sum();
                                
        return new(){
            OrderId=order.Id,
            PendingOrders=pendingOrders,
            Total=total
        };
    }
}