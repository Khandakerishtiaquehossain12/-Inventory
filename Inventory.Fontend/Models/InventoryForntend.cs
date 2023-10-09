

namespace Inventory.Fontend.Models
{
    public class InventoryForntend
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Product { get; set; } = string.Empty;

        public string Catëgory { get; set; } = string.Empty;

       

        public DateTimeOffset ReceiveDate { get; set; }

        public DateTimeOffset ServiceDate { get; set; }
    }
}
