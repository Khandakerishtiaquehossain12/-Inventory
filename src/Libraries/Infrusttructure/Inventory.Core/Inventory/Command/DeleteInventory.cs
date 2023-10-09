using MediatR;
using Inventory.Repositories.Interface;

using Inventory.Services.Model;
using Inventory.Repositiories.Base;

namespace Inventory.Core.Product.Command;
public record DeleteInventory(int Id) : IRequest<VmInventory>;
public class DeleteInventoryHandler : IRequestHandler<DeleteInventory, VmInventory>
{
    private readonly IInventoryRepository _inventoryRepository;
    public DeleteInventoryHandler(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }


    public async Task<VmInventory> Handle(DeleteInventory request, CancellationToken cancellationToken)
    {
        return await _inventoryRepository.Delete(request.Id);
    }
}

