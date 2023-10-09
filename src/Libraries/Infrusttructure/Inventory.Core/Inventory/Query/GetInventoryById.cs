using MediatR;
using Inventory.Repositories.Interface;

using Inventory.Services.Model;


namespace Inventory.Core.Product.Query;

public record GetInventoryById(int Id) : IRequest<VmInventory>;

public class GetStudentByIdHandler : IRequestHandler<GetInventoryById, VmInventory>
{
    private readonly IInventoryRepository _inventoryRepository;
    public GetStudentByIdHandler(IInventoryRepository InventoryRepository)
    {
        _inventoryRepository = InventoryRepository;
    }

    public async Task<VmInventory> Handle(GetInventoryById request, CancellationToken cancellationToken)
    {
        return await _inventoryRepository.GetById(request.Id);
    }
}
