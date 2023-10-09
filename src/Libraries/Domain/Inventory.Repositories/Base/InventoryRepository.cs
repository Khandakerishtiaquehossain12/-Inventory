using AutoMapper;
using Inventory.Shared.CommonRepository;
using Inventory.Repositories.Interface;

using Inventory.Infrastructure.DatabaseContex;

using Inventory.Services.Model;


namespace Inventory.Repositiories.Base;

public class InventoryRepository : RepositoryBase<Model.Inventory, VmInventory, int>, IInventoryRepository
{
    public InventoryRepository(IMapper mapper, InventoryDbContext dbContext) : base(mapper, dbContext)
    {
    }
}
