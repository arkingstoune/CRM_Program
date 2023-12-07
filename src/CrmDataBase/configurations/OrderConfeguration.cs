using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Crm.Data;
public sealed class OrderConfigarution : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        
        builder
        .HasOne(c => c.clients)
        .WithMany(c => c.orders);
    }
}