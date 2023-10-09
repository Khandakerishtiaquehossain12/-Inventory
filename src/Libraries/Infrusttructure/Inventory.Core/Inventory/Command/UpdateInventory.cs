using AutoMapper;
using MediatR;

using Inventory.Repositories.Interface;
using Inventory.Model;
using Inventory.Services.Model;
using Inventory.Repositiories.Base;

namespace Inventory.Core.Product.Command;
public record UpdateInventory(int Id, VmInventory Vminventory) : IRequest<VmInventory>;
public class UpdateStudentHandler : IRequestHandler<UpdateInventory, VmInventory>
{
    private readonly IInventoryRepository _inventoryRepository;
    private readonly IMapper _mapper;

    public UpdateStudentHandler(IInventoryRepository inventoryRepository, IMapper mapper)
    {
        _inventoryRepository = inventoryRepository;
        _mapper = mapper;
    }

    public async Task<VmInventory> Handle(UpdateInventory request, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<Model.Inventory>(request.Vminventory);
        return await _inventoryRepository.Update(request.Id, data);
    }
}

