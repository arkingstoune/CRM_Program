

using Microsoft.EntityFrameworkCore;

namespace Crm.Data;
public sealed class EfCoreOrderRepository : OrderRepository
{
    private readonly CrmDbContext _db ;
    public EfCoreOrderRepository(CrmDbContext crmDbContext)
    {
        _db = crmDbContext;
    }

    public async ValueTask<bool> CreateAsync(Order order, CancellationToken token  = default)
    {
        await _db.order.AddAsync(order, token);
        return await _db.SaveChangesAsync(token) > 0; 
    }
    public async ValueTask<int> CountAsync(CancellationToken token = default)
    {
        return  await _db.order.CountAsync(token);
    }
    public async ValueTask<bool> UpdateOrderAsync(string orderId, string orderSpes, CancellationToken token  = default)
    {
        Order order = await _db.order.SingleAsync(o => o.Id == orderId, token);
        order.OrderSpeciFication = orderSpes;
        _db.Update(order);
        return await  _db.SaveChangesAsync(token) > 0;
    }
}