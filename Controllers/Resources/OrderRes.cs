namespace pizza_management.Controllers.Resources;

public class OrderRes{
    public int OrderId { get; set; }
    public float Total { get; set; }
    public int PendingOrders { get; set; }
}