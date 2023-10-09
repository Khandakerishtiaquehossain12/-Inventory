using AutoMapper;
using MediatR;
using Inventory.Repositories.Interface;
using Inventory.Model;
using Inventory.Services.Model;


namespace Inventory.Core.Product.Command;

public record CreateInventory(VmInventory Vminventory) : IRequest<VmInventory>;

public class CreateInventoryHandler : IRequestHandler<CreateInventory, VmInventory>
{
    private readonly IInventoryRepository _inventoryRepository;
    private readonly IMapper _mapper;
    public CreateInventoryHandler(IInventoryRepository inventoryRepository, IMapper mapper)
    {
        _inventoryRepository = inventoryRepository;
        _mapper = mapper;
    }

    public async Task<VmInventory> Handle(CreateInventory request, CancellationToken cancellationToken)
    {


        var data = _mapper.Map<Model.Inventory>(request.Vminventory);
        return await _inventoryRepository.Add(data);
    }
}
