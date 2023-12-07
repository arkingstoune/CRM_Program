
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crm.Data;
public sealed class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder
            .HasKey(p => p.Id)
            .HasName("id");
        builder
            .Property(p => p.Id)
            .IsRequired();

        builder
            .HasMany(o => o.orders)
            .WithOne(o => o.clients);
    }
}
