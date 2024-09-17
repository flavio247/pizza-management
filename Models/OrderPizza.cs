using System.ComponentModel.DataAnnotations.Schema;

namespace pizza_management.Models;
public class OrderPizza
{
    public int Id { get; set; }
    [ForeignKey ("OrderId")]
    public int OrderId { get; set; }
    [ForeignKey ("PizzaId")]
    public int PizzaId { get; set; }
    public Pizza Pizza { get; set; }=null!;
    public Order Order { get; set; }=null!;
}