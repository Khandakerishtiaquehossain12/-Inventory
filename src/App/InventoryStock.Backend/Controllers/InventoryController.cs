using MediatR;

using Microsoft.AspNetCore.Mvc;
using Inventory.Core.Product.Command;
using Inventory.Core.Product.Query;

using Inventory.Services.Model;

namespace Inventory.Backend.Controllers;
[Route("api/[controller]")]
[ApiController]
public class InventoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public InventoryController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<VmInventory>> Get()
    {
        var data = await _mediator.Send(new GetAllInventoryQuery());
        return Ok(data);
    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult<VmInventory>> Get(int id)
    {
        var data = await _mediator.Send(new GetInventoryById(id));
        return Ok(data);
    }
    [HttpPost]
    public async Task<ActionResult<VmInventory>> PostAsync([FromBody] VmInventory vmInventory)
    {
        var data = await _mediator.Send(new CreateInventory(vmInventory));
        return Ok(data);

    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<VmInventory>> PutAsync(int id, [FromBody] VmInventory vmInventory)
    {
        var data = await _mediator.Send(new UpdateInventory(id, vmInventory));
        return Ok(data);
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<VmInventory>> DeleteAsync(int id)
    {
        var data = await _mediator.Send(new DeleteInventory(id));
        return Ok(data);
    }
}

