using Inventory.Shared.CommonRepository;
using Inventory.Services.Model;

namespace Inventory.Repositories.Interface;


public interface IInventoryRepository : IRepository<Model.Inventory, VmInventory, int>
{
}





