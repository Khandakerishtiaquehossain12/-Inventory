
using Inventory.Shared;
using Inventory.Shared.Enum;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Model;

public class Inventory : BaseEntity, IEntity

{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Product { get; set; } = string.Empty;

    public string Catëgory { get; set; } = string.Empty;

    public EntityStatus Status { get; set; } 

    public DateTimeOffset ReceiveDate { get; set; } 

    public DateTimeOffset ServiceDate { get; set; } 
    
}

