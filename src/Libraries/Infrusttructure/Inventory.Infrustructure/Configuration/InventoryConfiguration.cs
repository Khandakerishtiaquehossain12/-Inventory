using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Infrastructure.Configuration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Model.Inventory>
    {
        public void Configure(EntityTypeBuilder<Model.Inventory> builder)
        {
            builder.ToTable("Inventorys");
            builder.HasKey(x => x.Id);
        }
    }
}
