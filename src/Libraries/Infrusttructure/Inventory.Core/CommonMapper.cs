using AutoMapper;
using Inventory.Services.Model;

namespace Inventory.Core.Mapper;


public class CommonMapper : Profile
{
    public CommonMapper()
    {
        CreateMap<VmInventory,Model.Inventory>().ReverseMap();
        
    }
}
