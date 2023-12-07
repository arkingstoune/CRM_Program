using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;    
namespace Crm.Data;

public sealed class CrmDbContext : DbContext
{
    public DbSet<Client> client {get; set;}
    public DbSet<Order> order {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(optionsBuilder.IsConfigured)
            return;
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User ID=postgres;Password=typedef;Database=lesson35db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfigarution());
    }
}   