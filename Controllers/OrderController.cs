using Microsoft.AspNetCore.Mvc;
using pizza_management.Controllers.Resources;
using pizza_management.Models;
using pizza_management.Patterns;

namespace pizza_management.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService orderService;

    public OrderController(IOrderService orderService)
    {
        this.orderService = orderService;
    }

    [HttpGet("GetLastOrder")]
    public IActionResult GetLastOrder()
    {
        return Ok(orderService.GetLastOrder());
    }
    [HttpPost("Save")]
    public IActionResult Save([FromBody] OrderReq req)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        if (req.PizzaId.Length==0)
            return BadRequest("Insert at least one pizza!");

        return Ok(orderService.Save(req));
    }
}
