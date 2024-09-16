using pizza_management.Controllers.Resources;
using pizza_management.Models;

namespace pizza_management.Patterns;

public interface IOrderService {
    OrderRes Save(OrderReq req);
    OrderDto GetLastOrder();
}