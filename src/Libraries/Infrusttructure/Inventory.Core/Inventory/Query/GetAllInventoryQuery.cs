using AutoMapper;
using MediatR;
using Inventory.Repositories.Interface;

using Inventory.Services.Model;


namespace Inventory.Core.Product.Query
{
    public record GetAllInventoryQuery() : IRequest<IEnumerable<VmInventory>>;

    public class GetAllInventoryQueryHandler : IRequestHandler<GetAllInventoryQuery, IEnumerable<VmInventory>>
    {
        private readonly IInventoryRepository _inventoryRepository;
        public GetAllInventoryQueryHandler(IInventoryRepository InventoryRepository, IMapper mapper)
        {
            _inventoryRepository = InventoryRepository;
        }
        public async Task<IEnumerable<VmInventory>> Handle(GetAllInventoryQuery request, CancellationToken cancellationToken)
        {
            var result = await _inventoryRepository.GetList();
            return result;
        }
    }
}

