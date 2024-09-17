using System.Collections.ObjectModel;

namespace pizza_management.Models;
public class Order{
    public int Id { get; set; }
    public DateTime OrderTime { get; set; }
    public bool Completed { get; set; }
    public ICollection<OrderPizza> OrderPizzas { get; set; } = [];

}