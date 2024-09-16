namespace pizza_management.Controllers.Resources;

public class OrderDto{
    public int Id { get; set; }
    public ICollection<PizzaDto> Pizze { get; set; }
}